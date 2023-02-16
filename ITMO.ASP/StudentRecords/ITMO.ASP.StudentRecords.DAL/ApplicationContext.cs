using ITMO.ASP.StudentRecords.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }

        public ApplicationContext()
            : base("StudentDB")
        { 
           
        }
    }
}
