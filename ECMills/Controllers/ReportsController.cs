using ECMills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECMills.Controllers
{
    [RoutePrefix("Reports")]
    public class ReportsController : Controller
    {
        private readonly ECMills_DBConnection DBContext;

        public ReportsController()
        {
            DBContext = new ECMills_DBConnection();
        }

        // GET: Reports
        [Route("Management")]
        public ActionResult Management()
        {
            var JobCountByOffice = sp_Report_GetJobCountByOffices();
            return View(JobCountByOffice);
        }

        public List<sp_Report_GetJobCountByOffice_Result> sp_Report_GetJobCountByOffices()
        {
            return DBContext.sp_Report_GetJobCountByOffice().ToList();
        }
    }
}