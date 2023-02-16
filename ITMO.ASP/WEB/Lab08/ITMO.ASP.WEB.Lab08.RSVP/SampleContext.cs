using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ITMO.ASP.WEB.Lab08.RSVP
{
    public class SampleContext : DbContext
    {
        public SampleContext()
            : base("SeminarBD")
        { }
        public DbSet<GuestResponse> GuestResponses { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}