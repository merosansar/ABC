using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Controllers
{
    public class DropdownLoadController : Controller
    {
        // GET: DropdownLoad
        public ActionResult LoadDropdown(string SearchText, string SearchId, bool IsNepali)
        {
            List<SelectListItem> rslt = ABC.Models.Dropdown.DropDownListData(SearchText, SearchId, IsNepali);
            return this.Json(rslt, JsonRequestBehavior.AllowGet);
           
        }

        

    }
}