﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;
using System.Dynamic;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("Arrangement/{id:int}")]
    public class ArrangementController : Controller
    {
        private readonly ECMills_DBConnection DBContext;
      
        public ArrangementController()
        {
            DBContext = new ECMills_DBConnection();
            System.Web.HttpContext.Current.Session["PreviousController"] = System.Web.HttpContext.Current.Session["CurrentController"];
            System.Web.HttpContext.Current.Session["CurrentController"] = "Arrangement";
        }

        [Route("Info")]
        public ActionResult Info(Int16 id)
        {
            System.Web.HttpContext.Current.Session["PreviousPage"] = System.Web.HttpContext.Current.Session["CurrentPage"];
            System.Web.HttpContext.Current.Session["CurrentPage"] = "Info";

            return View();
        }

        [Route("~/Arrangement/List")]
        public ActionResult ArrangementList()
        {
            Session["PreviousPage"] = Session["CurrentPage"];
            Session["CurrentPage"] = "List";
            var deceased = sp_GetDeceasedList();
 
            return View(deceased);
        }

        public ActionResult CaptureID(Int16 id)
        {
            Session["DeceasedID"] = id;

            return RedirectToAction("Info", id);
        }

        [HttpGet]
        [Route("Deceased")]
        public ActionResult Deceased(Int16 id)
        {
            Int16 DeceasedID = id;
            Session["PreviousPage"] = Session["CurrentPage"];
            Session["CurrentPage"] = "Deceased";
            ViewBag.DeceasedID = DeceasedID.ToString();

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

        public ActionResult Contacts(Int16 id)
        {
            Session["PreviousPage"] = Session["CurrentPage"];
            Session["CurrentPage"] = "Contacts";
            dynamic dynamicObject = new ExpandoObject();
            dynamicObject.DeceasedContactList            = sp_GetDeceasedContactsList(id);
            dynamicObject.DeceasedContactsContactDetails = sp_GetDeceasedContactsContactDetails(id);

            return View(dynamicObject);
        }

        public ActionResult Ceremony(Int16 id)
        {
            Session["PreviousPage"] = Session["CurrentPage"];
            Session["CurrentPage"] = "Ceremony";
            return View(id);
        }

        public ActionResult Coffin(Int16 id)
        {
            return View();
        }

        public ActionResult Transport(Int16 id)
        {
            Session["PreviousPage"] = Session["CurrentPage"];
            Session["CurrentPage"] = "Transport";
            return View();
        }

        public ActionResult Documents(Int16 id)
        {
            Session["PreviousPage"] = Session["CurrentPage"];
            Session["CurrentPage"] = "Documents";
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