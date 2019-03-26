using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECMills.Models;
using System.Web.Mvc.Html;
using System.Data.SqlClient;

namespace ECMills.Controllers
{
    public class CustomersController : Controller
    {

        public ViewResult Index(string surname)
        {
            if (!String.IsNullOrEmpty(surname))
            {

                ECMillsDBConnection DB = new ECMillsDBConnection();
                string sqlquery = "SELECT * FROM Client WHERE C_NAME LIKE '%" + surname + "%' ORDER BY C_ID ASC";

                List<Client> Clients = DB.Clients.SqlQuery(sqlquery).ToList();

                return View(Clients);
            }
            else
            {
                return View("NoCustomers");
            }
        }



        public ActionResult Details(int id)
        {
            var customer = GetCustomers(id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private List<ECMills.Models.sp_GetClientFile_Result> GetCustomers(int id)
        {

            using (var context = new ECMillsDBConnection())
            {
                var courses = context.sp_GetClientFile(id).ToList();

                return courses;
            }

        }

        public ViewResult Test()
        {
            return View();
        }
    }
}