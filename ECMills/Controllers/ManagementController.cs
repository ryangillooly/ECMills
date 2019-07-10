using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECMills.Models;

namespace ECMills.Controllers
{
    [RoutePrefix("Management")]
    public class ManagementController : Controller
    {
        private readonly ECMills_DBConnection DBContext;

        public ManagementController()
        {
            DBContext = new ECMills_DBConnection();
        }

        // GET: Management
        [Route("Crematoriums")]
        public ActionResult Crematoriums()
        {
            var Crematoriums = sp_GetCrematoriums();
            return View(Crematoriums);
        }

        [Route("Churches")]
        public ActionResult Churches()
        {
            var Churches = sp_GetChurches();
            return View(Churches);
        }

        public List<sp_GetCrematoriums_Result> sp_GetCrematoriums()
        {
            return DBContext.sp_GetCrematoriums().ToList();
        }

        public List<sp_GetChurches_Result> sp_GetChurches()
        {
            return DBContext.sp_GetChurches().ToList();
        }
    }
}