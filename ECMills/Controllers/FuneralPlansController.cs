using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("FuneralPlans")]
    public class FuneralPlansController : Controller
    {
        // GET: FuneralPlans
        [Route("")]
        public ActionResult FuneralPlans()
        {
            return View();
        }
    }
}