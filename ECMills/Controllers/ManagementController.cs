using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("Management")]
    public class ManagementController : Controller
    {
        // GET: Management
        [Route("Crematoriums")]
        public ActionResult Crematoriums()
        {
            return View();
        }
    }
}