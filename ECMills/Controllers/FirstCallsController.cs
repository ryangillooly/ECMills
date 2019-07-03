using ECMills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("FirstCalls")]
    public class FirstCallsController : Controller
    {
        private readonly ECMills_DBConnection DBContext;

        public FirstCallsController()
        {
            DBContext = new ECMills_DBConnection();
        }

        // GET: FirstCalls
        [Route("")]
        public ActionResult FirstCalls()
        {
            return View();
        }

        [Route("test")]
        public ActionResult test()
        {
            return View();
        }
    }
}