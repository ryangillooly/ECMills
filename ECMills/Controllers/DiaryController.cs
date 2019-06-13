using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("Diary")]
    public class DiaryController : Controller
    {
        // GET: Diary
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}