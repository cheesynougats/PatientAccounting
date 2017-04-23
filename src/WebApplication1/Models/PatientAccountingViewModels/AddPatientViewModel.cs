using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.PatientAccountingViewModels
{
    public class AddPatientViewModel
    {
        [Required]
        [Display(Name = "Patient name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Patient address")]
        public Address Address { get; set; }

        [Required]
        [Display(Name = "Patient telephone number")]
        public string Phone { get; set; }

        [EmailAddress]
        [Display(Name = "Patient email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Patient birth date")]
        public DateTime Birthdate { get; set; }

        [Display(Name = "Patient Social Security number")]
        public string SSN { get; set; }


    }
}
