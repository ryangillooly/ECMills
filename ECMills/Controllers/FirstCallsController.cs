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
        // GET: FirstCalls
        [Route("")]
        public ActionResult Index()
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