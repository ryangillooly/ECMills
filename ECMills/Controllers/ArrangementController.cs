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
            ViewBag.CurrentPage = "Home";
            return View();
        }

        public ActionResult List()
        {
            ViewBag.CurrentPage = "List";
            var deceased = sp_GetDeceasedList();
            return View(deceased);
        }

        [HttpGet]
        public ActionResult Deceased(Int16 id)
        {
            Int16 DeceasedID = id;
            ViewBag.CurrentPage = "Deceased";
            ViewBag.DeceasedID = DeceasedID.ToString();

            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.DeceasedProfile = sp_GetDeceasedProfile(DeceasedID);
            dynamicObject.DeceasedAddressList = sp_GetDeceasedAddressList(DeceasedID);

            return View(dynamicObject);
        }

        public ActionResult ProfileUpdate(string Name, string KnownAs, string Gender, int Age, DateTime DOB,
                                          DateTime TimeOfDeath, string MaritalStatus, string Occupation,
                                          string Religion, string Reldom)
        {
            string SQLQuery = "Here we go...";

            SQLQuery = SQLQuery + Name + ", " + Reldom;

            return Content(SQLQuery);

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