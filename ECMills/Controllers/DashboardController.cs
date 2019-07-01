﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;
using System.Web.Mvc;


namespace ECMills.Controllers
{
    [RoutePrefix("Dashboard")]
    public class DashboardController : Controller
    {
        private readonly ECMills_DBConnection DBContext;

        public DashboardController()
        {
            DBContext = new ECMills_DBConnection();
        }

        // GET: Dashboard
        [Route("")]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Route("test")]
        public ActionResult testtable()
        {
            return View();
        }
    }
}