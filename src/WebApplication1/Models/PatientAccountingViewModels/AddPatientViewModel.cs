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
        public string Name { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public string SSN { get; set; }


    }
}
