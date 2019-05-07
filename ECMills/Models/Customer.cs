using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace ECMills.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}