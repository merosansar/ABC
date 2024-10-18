using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC.Models
{
    public static class Dropdown
    {
        
        public static List<SelectListItem> DropDownListData(string SearchText, string SearchId,bool IsNepali)
        {

            List<SelectListItem> list = new List<SelectListItem>();
           
            using (ABCEntities1 conn = new ABCEntities1())
            {

                List<LoadDropdownList_Result> AllList = conn.LoadDropdownList(SearchText,Convert.ToInt32( SearchId), IsNepali).ToList();              
                if((SearchId==null || SearchId == "0" || SearchId=="")&& IsNepali==false) { 
                list.Add(new SelectListItem() { Text = "All", Value = "", Selected = true });
                }
                if ((SearchId == null || SearchId == "0" || SearchId!="" || SearchId == "") && IsNepali == true)
                {
                    list.Add(new SelectListItem() { Text = "सबै", Value = "", Selected = true });
                }
                foreach (LoadDropdownList_Result row in AllList)
                {
                    list.Add(new SelectListItem() { Text = row.Name.Trim(','), Value = row.Id.ToString(), Selected = false });
                }

            }
            return list;
        }

    }


}