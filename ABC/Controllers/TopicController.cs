using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class TopicController : Controller
    {
        // GET: Topic
        private readonly ABCEntities1 db = new ABCEntities1();
        public ActionResult Index()
        {
            return View();
        }

        // GET: Topic/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Topic/Create
        public ActionResult Create()
        {
            var t = new Topic();
            return View(t);
        }

        // POST: Topic/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string TopicName = collection["TopicName"].TrimEnd(',');
                //string ExamId = collection["ExamId"].Trim(',');
                string SubjectID = collection["SubjectID"].Trim(',');
                string IsNepali = collection["IsNepali"].Trim(',');
                string isNepaliBool = (IsNepali == "true") ? "1" : "0";

                var i = db.iAddTopic("i", null, TopicName, Convert.ToInt32(SubjectID), Convert.ToBoolean(IsNepali));
                ViewBag.Message = i;
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Topic/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Topic/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Topic/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Topic/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
