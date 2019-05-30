using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;
using System.Dynamic;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [Route("Arrangement")]
    public class ArrangementController : Controller
    {
        private readonly ECMills_DBConnection DBContext;
      
        public ArrangementController()
        {
            DBContext = new ECMills_DBConnection();
        }

        [Route("~/Arrangement/List")]
        public ActionResult ArrangementList()
        {
            var deceased = sp_GetDeceasedList();
            return View(deceased);
        }

        [Route("{id}/Info")]
        public ActionResult Info(Int16 id)
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult CaptureID(Int16 id)
        {
            Session["DeceasedID"] = id;
            return RedirectToAction("Info", "Arrangement", new { id });
        }

        [HttpGet]
        [Route("{id}/Deceased")]
        public ActionResult Deceased(Int16 id)
        {
            Int16 DeceasedID = id;

            dynamic dynamicObject             = new ExpandoObject();
            dynamicObject.DeceasedProfile     = sp_GetDeceasedProfile(DeceasedID);
            dynamicObject.DeceasedAddressList = sp_GetDeceasedAddressList(DeceasedID);

            return View(dynamicObject);
        }

        public ActionResult ProfileUpdate(string Name, string Known_As, string Gender, int Age, DateTime DOB,
                                  DateTime TimeOfDeath, string MaritalStatus, string Occupation,
                                  string Religion, string Reldom)
        {
            return Content("YEP");
        }

        [Route("{id}/Contacts")]
        public ActionResult Contacts(Int16 id)
        {
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.DeceasedContactList            = sp_GetDeceasedContactsList(id);
            dynamicObject.DeceasedContactsContactDetails = sp_GetDeceasedContactsContactDetails(id);

            return View(dynamicObject);
        }

        [Route("{id}/Ceremony")]
        public ActionResult Ceremony(Int16 id)
        {
            return View(id);
        }

        [Route("{id}/Coffin")]
        public ActionResult Coffin(Int16 id)
        {
            return View();
        }

        [Route("{id}/Transport")]
        public ActionResult Transport(Int16 id)
        {
            return View();
        }

        [Route("{id}/Documents")]
        public ActionResult Documents(Int16 id)
        {
            return View();
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

        public List<sp_GetDeceasedContactsList_Result> sp_GetDeceasedContactsList(Int16 id)
        {
            return DBContext.sp_GetDeceasedContactsList(id).ToList();
        }
        
        public List<sp_GetDeceasedContactsContactDetails_Result> sp_GetDeceasedContactsContactDetails(Int16 id)
        {
            return DBContext.sp_GetDeceasedContactsContactDetails(id).ToList();
        }
        
    }
}