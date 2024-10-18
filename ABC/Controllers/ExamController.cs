using ABC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class ExamController : Controller
    {

        private  readonly ABCEntities1 db = new ABCEntities1();
        // GET: Exam
        public ActionResult Index()
        {
            bool IsNepali = false;
            ExamViewModel m = new ExamViewModel();
            List<sAddExam_Result> i = db.sAddExam("s", null, null, User.Identity.Name, Convert.ToBoolean(IsNepali)).ToList();
            m.ExamListModel = i;
            return View(m);
        }

        // GET: Exam/Details/5
        public ActionResult Details(int id)
        {
           sAddExam_Result i = db.sAddExam("s", id, null, User.Identity.Name, true).ToList().FirstOrDefault();
            return View(i);
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
          
               var e = new Exam();
           
           
            return View(e);
        }

        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string examName = collection["ExamName"];
                string IsNepali = collection["IsNepali"];

                var i = db.iAddExam("i",null, examName, User.Identity.Name,Convert.ToBoolean( IsNepali));
                ViewBag.Message = i;
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int id)
        {
            return View(id);
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index",id );
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            return View(id);
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index", collection);
            }
            catch
            {
                return View(id);
            }
        }


        public ActionResult _ExamList(Nullable<bool> IsNepali)
        {

           List< sAddExam_Result> i = db.sAddExam("s", null, null, User.Identity.Name, Convert.ToBoolean(IsNepali)).ToList();
            return View(i);

        }

    }
}
