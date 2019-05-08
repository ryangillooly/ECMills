using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;
using System.Dynamic;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    public class ArrangementController : Controller
    {
        private ECMills_DBModel_Connection DBContext;

        public ArrangementController()
        {
            DBContext = new ECMills_DBModel_Connection();
        }

        // GET: Funeral

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult List()
        {
            var deceased = sp_GetDeceasedList();
            return View(deceased);
        }

        public ActionResult Deceased(Int16 id)
        {
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.Profile = sp_GetDeceasedProfile(id);
            dynamicObject.List    = sp_GetDeceasedAddressList(id);

            return View(dynamicObject);
        }

        public ActionResult EditDeceased(Int16 id)
        {
            var deceasedProfile = sp_GetDeceasedProfile(id);
            return View(deceasedProfile);
        }

        public List<sp_GetDeceasedList_Result> sp_GetDeceasedList()
        {
            return DBContext.sp_GetDeceasedList().ToList();
        }

        public List<sp_GetDeceasedProfile_Result> sp_GetDeceasedProfile(Int16 id)
        {
            return DBContext.sp_GetDeceasedProfile(id).ToList();
        }

        public List<sp_GetDeceasedAddressList_Result> sp_GetDeceasedAddressList(Int16 id)
        {
            return DBContext.sp_GetDeceasedAddressList(id).ToList();
        }

    }
}