using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ASP.StudentRecords.DAL.Models
{
    public class StudentAddModel
    {
        [StringLength(20, ErrorMessage = "Maximum length - 20")]
        [MinLength(2, ErrorMessage = "Minimum length - 1")]
        [Required(ErrorMessage = "Fill in the field")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Use only latin")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "Maximum length - 30")]
        [MinLength(2, ErrorMessage = "Minimum length - 1")]
        [Required(ErrorMessage = "Fill in the field")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Use only latin")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [StringLength(1, ErrorMessage = "Maximum length - 1")]
        [Required(ErrorMessage = "Fill in the field")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Use only latin")]
        [DisplayName("Score")]
        public string ScoreDescription { get; set; }
    }
}
