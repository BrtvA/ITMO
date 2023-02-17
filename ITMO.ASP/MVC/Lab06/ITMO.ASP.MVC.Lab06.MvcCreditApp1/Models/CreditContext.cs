using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.ASP.MVC.Lab06.MvcCreditApp1.Models
{
    public class CreditContext : DbContext
    {
        public CreditContext()
            : base("CreditBD")
        { }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}