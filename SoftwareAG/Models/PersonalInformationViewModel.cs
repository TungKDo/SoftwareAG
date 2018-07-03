using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareAG.Models
{
    public class PersonalInformationViewModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(25, MinimumLength = 1)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(25, MinimumLength = 1)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(25, MinimumLength = 1)]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [StringLength(25, MinimumLength = 1)]
        public string PhoneNumber { get; set; }
    }
}
