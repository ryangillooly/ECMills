using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECMills.Models;
using System.Web.Mvc.Html;
using System.Data.SqlClient;
using System.Web.Routing;

namespace ECMills.Controllers
{
    public class DeceasedController : Controller
    {
        private ECMills_DBModel_Connection DBContext;

        public DeceasedController()
        {
            DBContext = new ECMills_DBModel_Connection();
        }

        public ActionResult List()
        {
            var deceased = sp_GetDeceasedList();

            return View(deceased);
        }

        public new ActionResult Profile(Int16 DeceasedID)
        {
            var deceasedProfile   = sp_GetDeceasedProfile(DeceasedID);
            var deceasedAddresses = sp_GetDeceasedAddressList(DeceasedID);
            return View(deceasedProfile);
        }

        public new ActionResult EditProfile(Int16 DeceasedID)
        {
            var deceasedProfile = sp_GetDeceasedProfile(DeceasedID);

            return View(deceasedProfile);
        }


        private List<sp_GetDeceasedList_Result> sp_GetDeceasedList()
        {
            return DBContext.sp_GetDeceasedList().ToList();
        }

        private List<sp_GetDeceasedProfile_Result> sp_GetDeceasedProfile(Int16 DeceasedID)
        {
            return DBContext.sp_GetDeceasedProfile(DeceasedID).ToList();
        }

        private List<sp_GetDeceasedAddressList_Result> sp_GetDeceasedAddressList(Int16 DeceasedID)
        {
            return DBContext.sp_GetDeceasedAddressList(DeceasedID).ToList();
        }




    }
}