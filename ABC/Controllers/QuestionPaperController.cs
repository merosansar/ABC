using ABC.Models;
using ABC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class QuestionPaperController : Controller
    {
        // GET: QuestionPaper
        //private ABCDbContext db = new ABCDbContext(); // Your DbContext
        private readonly ABCEntities1 db = new ABCEntities1();

        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetQuestionPaper()
        {
            var i = new QuestionPaper();

            return View(i);
        }
       
        [HttpPost]
        public ActionResult GetQuestionPaper(QuestionPaper q)
        {
            List<GetQuestionPaper_Result> i = db.GetQuestionPaper(q.PaperId, q.IsNepali).ToList();
            TempData["IsNepali"] = q.IsNepali;
            return View("DisplayStaticQuestionPaper", i);
        }

        [ValidateAntiForgeryToken]
        public ActionResult DisplayStaticQuestionPaper(List<GetQuestionPaper_Result> list)
        {

            return View(list);
        }

        public ActionResult GenerateQuestionPaper()
        {
            var i = new GenerateQuestionPaperViewModel();
            
            return View(i);
        }

        // POST: Question/GenerateQuestionPaper
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult GenerateQuestionPaper(GenerateQuestionPaperViewModel model)
        {

            List<GenerateRandomQuestionPaper_Result> i = db.GenerateRandomQuestionPaper(null, model.NumberOfQuestions, model.PaperTitle, model.PaperDescription, model.ExamName, model.IsNepali).ToList();
            TempData["IsNepali"] = model.IsNepali;


            return View("DisplayQuestionPaper", i);
           
        }       


        // Action method to display the question paper in a new tab/window
        [ValidateAntiForgeryToken]
        public ActionResult DisplayQuestionPaper(List<GenerateRandomQuestionPaper_Result> list)
        {
            
            return View(list);
        }


    }
}