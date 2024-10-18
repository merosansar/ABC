using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private readonly ABCEntities1 db = new ABCEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u)
        {
            var i = db.aUserAuthentication(u.Username, u.PasswordHash, null).FirstOrDefault();
            if (i.Result=="1")
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult Create( )
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(User u)
        {
            var i = db.iUserInsertUpdate("INSERT", null, u.Username,u.Email,u.PasswordHash,u.FirstName,u.LastName,u.DateOfBirth,u.GenderId,u.PhoneNumber,u.Address,u.CountryId,u.ProvinceId,u.ZoneId,u.DistrictId,u.UserTypeId,u.ProfilePicture).FirstOrDefault();
            ViewBag.Message = i.Result;
            return View("Login");
        }
    }
}