using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCApp.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "We need your work email address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm  Email")]
        [Compare("EmailAddress", ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "You need to provide a long enough password.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match")]
        public string ConfirmPassword { get; set; }
    }
}