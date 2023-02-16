using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL.Entities
{
    public class Score
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "smallint")]
        public Int16 ScoreValue { get; set; }


        [StringLength(10)]
        [Column(TypeName = "varchar")]
        public string ScoreDescription { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
    }
}
