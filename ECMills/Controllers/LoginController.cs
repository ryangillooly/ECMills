﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [Route("~/", Name = "Login")]
    public class LoginController : Controller
    {
        // GET: Login
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}