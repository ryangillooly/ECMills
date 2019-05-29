using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("Dashboard")]
    public class DashboardController : Controller
    {
        private readonly ECMills_DBConnection DBContext;

        public DashboardController()
        {
            DBContext = new ECMills_DBConnection();

            if (System.Web.HttpContext.Current.Session["CurrentController"] == null)
            {
                System.Web.HttpContext.Current.Session["PreviousController"] = "";
            }
            else
            {
                System.Web.HttpContext.Current.Session["PreviousController"] = System.Web.HttpContext.Current.Session["CurrentController"];
            }

            System.Web.HttpContext.Current.Session["CurrentController"] = "Arrangement";
        }

        // GET: Dashboard
        [Route("")]
        public ActionResult Index()
        {
            System.Web.HttpContext.Current.Session["PreviousPage"] = System.Web.HttpContext.Current.Session["CurrentPage"];
            System.Web.HttpContext.Current.Session["CurrentPage"] = "Dashboard";
            return View();
        }
    }
}