using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ECMills.Models;

namespace ECMills.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<string> Churches { get; set; }
        public ECMills.Models.Client Client { get; set; }
    }
}