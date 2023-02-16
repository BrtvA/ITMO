using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL.Entities
{
    public class Student
    {
        public int Id { get; set; }


        [StringLength(20)]
        [Required]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }


        [StringLength(30)]
        [Required]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }


        [Required]
        public int ScoreId { get; set; }


        public Score Score { get; set; }
    }
}
