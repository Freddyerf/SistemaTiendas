using Final.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Your First Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Your Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(250)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [StringLength(250)]
        [Display(Name = "Company address")]
        public string CompanyAddress { get; set; }
        [Phone]
        [StringLength(20)]
        [Display(Name = "Company telephone number")]
        public string CompanyTelephone { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
