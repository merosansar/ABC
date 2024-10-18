using ABC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        private readonly ABCEntities1 db = new ABCEntities1();
        public ActionResult Index()
        {
            bool IsNepali = false;

            List<sAddSubject_Result> i = db.sAddSubject("s", null, null, null, IsNepali).ToList();

            return View(i);

        }

        // GET: Subject/Details/5
        public ActionResult Details(int id)
        {
            bool IsNepali = false;
            eAddSubject_Result i = db.eAddSubject("s", id, null, null, Convert.ToBoolean(IsNepali)).ToList().FirstOrDefault();
            return View(i);
        }

        // GET: Subject/Create
        public ActionResult Create()
        {
            var s = new Subject();
            return View(s);

        }

        // POST: Subject/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            try
            {
                string SubjectName = collection["SubjectName"].TrimEnd(',');
                string ExamId = collection["ExamId"].Trim(',');
                string IsNepali = collection["IsNepali"].Trim(',');
                string isNepaliBool = (IsNepali == "true") ? "1" : "0";

                var i = db.AddSubject("i", null, SubjectName, Convert.ToInt32(ExamId), Convert.ToBoolean(IsNepali));
                ViewBag.Message = i;
                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subject/Edit/5
        public ActionResult Edit(int id)
        {
            bool IsNepali = false;

            eAddSubject_Result i = db.eAddSubject("e", id, null, null, Convert.ToBoolean(IsNepali)).ToList().FirstOrDefault();
            return View(i);
        }

        // POST: Subject/Edit/5
        [HttpPost]
        public ActionResult Edit( eAddSubject_Result m)
        {

            try
            {
                // TODO: Add update logic here
                
               
                List<uAddSubject_Result> i = db.uAddSubject("u", m.SubjectID, m.SubjectName, m.ExamId, m.IsNepali).ToList();
                List<sAddSubject_Result> list = db.sAddSubject("s", null, null, null, Convert.ToBoolean(m.IsNepali)).ToList();
                return View("Index", list);
            }
            catch
            {
                return View(m);
            }
        }

        // GET: Subject/Delete/5
        public ActionResult Delete(int id)
        {
            bool IsNepali = false;
            eAddSubject_Result i = db.eAddSubject("e", id, null, null, Convert.ToBoolean(IsNepali)).ToList().FirstOrDefault();
            return View(i);
        }

        // POST: Subject/Delete/5
        [HttpPost]
        public ActionResult Delete(eAddSubject_Result m)
        {
            try
            {
                // TODO: Add delete logic here
               
                bool IsNepali = false;
                dAddSubject_Result i = db.dAddSubject("d", m.SubjectID, null, null,null).ToList().FirstOrDefault();
                List<sAddSubject_Result> list = db.sAddSubject("s", null, null, null, Convert.ToBoolean(IsNepali)).ToList();
                return RedirectToAction("Index", list);
            }
            catch
            {
                return View(m);
            }
        }
    }
}
