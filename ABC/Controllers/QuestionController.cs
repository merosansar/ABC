using ABC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        private readonly ABCEntities1 db = new ABCEntities1();


        public ActionResult Index()
        {
            return View();
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View(id);
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            var q = new Question();
            return View(q);
        }

        // POST: Question/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var q = new Question();
            string name = collection["Name"].TrimEnd(',');
            int marks = 0;
            int TopicId  = Convert.ToInt32(collection["Topic"].Trim(','));
            string IsNepali = collection["IsNepali"].Trim(',');

            try
            {
                List<iManageQuestion_Result> i = db.iManageQuestion("INSERT", null, name, marks, User.Identity.Name, null,null,null,Convert.ToBoolean(IsNepali), TopicId).ToList();
                
                return View("Create",q);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while creating the question: " + ex.Message);
                return View();
               
            }
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {
            return View(id);
        }

        // POST: Question/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index",id);
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
            return View(id);
        }

        // POST: Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index",id);
            }
            catch
            {
                return View(collection);
            }
        }
    }
}
