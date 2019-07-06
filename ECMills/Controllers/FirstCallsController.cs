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
            var FirstCallsList = sp_GetFirstCallsList();
            return View(FirstCallsList);
        }

        public List<sp_GetFirstCallsList_Result> sp_GetFirstCallsList()
        {
            return DBContext.sp_GetFirstCallsList().ToList();
        }

        public List<sp_GetFirstCalls_Result> sp_GetFirstCalls(Int16 id)
        {
            return DBContext.sp_GetFirstCalls(id).ToList();
        }
    }
}