using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL.Models
{
    public class StudentAllModel: StudentAddModel
    {
        [DisplayName("Score value")]
        public int ScoreValue { get; set; }
    }
}
