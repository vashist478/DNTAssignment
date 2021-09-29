using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FormValidation_Assignment1.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation_Assignment1.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please enter confirm password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Enter your contact number")]
        public string ContactNumber { get; set; }

        [BindProperty, Required(ErrorMessage = "Select gender")]
        public Gender Gender { get; set; }

        [ValidateCheckBoxAttribute(ErrorMessage = "Please check terms")]
        public bool Terms { get; set; }
        [ValidateCheckBoxAttribute(ErrorMessage = "Select gender")]
        public string[] Genders = new[] { "Male", "Female", "Unspecified" };

        [Required(ErrorMessage = "Please enter city")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please select country")]
        public string Country { get; set; }

    }

    public enum Gender
    {
        Male,
        Female,
        Others
    }
}
