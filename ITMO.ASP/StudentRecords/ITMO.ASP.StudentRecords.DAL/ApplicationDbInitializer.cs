using ITMO.ASP.StudentRecords.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL
{
    public class ApplicationDbInitializer 
        : DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            context.Scores.Add(new Score { 
                ScoreValue=2,
                ScoreDescription= "F"
            });
            context.Scores.Add(new Score { 
                ScoreValue = 3,
                ScoreDescription = "C"
            });
            context.Scores.Add(new Score { 
                ScoreValue = 4,
                ScoreDescription = "B"
            });
            context.Scores.Add(new Score {
                ScoreValue = 5,
                ScoreDescription = "A"
            });
            base.Seed(context);
        }
    }
}
