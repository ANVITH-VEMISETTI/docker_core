using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace docker_core.Models
{
    public class Admitions
    {
        [Key]
        [Required(ErrorMessage = "AdmissionId Field is Required")]
        public Int32 AdmissionId { get; set; }

        [Required(ErrorMessage = "StudentName Field is Required")]
        public string StudentName { get; set; }

        //[Required(ErrorMessage = "AdmissionDate Field is Required")]
        //public DateAndTime AdmissionDate { get; set; }

        [Required(ErrorMessage = "Branch Field is Required")]
        public string Branch { get; set; }
    }
}
