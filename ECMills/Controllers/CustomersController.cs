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
            ECMillsEntities DB = new ECMillsEntities();

            string sqlquery = "SELECT * FROM Client WHERE C_NAME LIKE '%" + surname + "%' ORDER BY C_ID ASC";

            List<Client> Clients = DB.Clients.SqlQuery(sqlquery).ToList();
            return View(Clients);
        }



        public ActionResult Details(int id)
        {
            var customer = GetCustomers(id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private IEnumerable<Client> GetCustomers(int id)
        {
            var idParam = new SqlParameter
            {
                ParameterName = "Id",
                Value = id
            };

            ECMillsEntities DB = new ECMillsEntities();
           // string sqlquery = "EXEC Web.Sp_GetClientFile @Id", idParam;

            List<Client> ClientDetails = DB.Clients.SqlQuery("EXEC Web.Sp_GetClientFile @Id", idParam).ToList();

            return ClientDetails;
        }

        public ViewResult Test()
        {
            return View();
        }
    }
}