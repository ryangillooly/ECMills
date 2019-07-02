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
            var deceased = sp_GetDeceasedList();
            return View(deceased);
        }

        public List<sp_GetDeceasedList_Result> sp_GetDeceasedList()
        {
            return DBContext.sp_GetDeceasedList().ToList();
        }
    }
}