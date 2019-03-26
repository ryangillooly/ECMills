using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECMills.Models;
using System.Web.Mvc.Html;

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



        public ActionResult Details(string name)
        {
            var customer = GetCustomers(name);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }


        private IEnumerable<Client> GetCustomers(string name)
        {
            ECMillsEntities DB = new ECMillsEntities();
            string sqlquery = "SELECT * FROM Client WHERE C_NAME LIKE '%" + name + "%' ORDER BY C_ID ASC";

            List<Client> ClientDetails = DB.Clients.SqlQuery(sqlquery).ToList();

            return ClientDetails;
        }

        public ViewResult Test()
        {
            return View();
        }
    }
}