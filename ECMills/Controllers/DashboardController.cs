using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ECMills_DBConnection DBContext;

        public DashboardController()
        {
            DBContext = new ECMills_DBConnection();
        }

        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Arrangements()
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