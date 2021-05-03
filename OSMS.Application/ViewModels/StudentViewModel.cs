using OSMS.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSMS.Application.Entities
{
    public class StudentViewModel : BaseViewModel
    {
        public int StudentId { get; set; }
        [Display(Name = "Enrollment No")]
        public string EnrollmentNo { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string EmailID { get; set; }
        public string Address { get; set; }

    }
}
