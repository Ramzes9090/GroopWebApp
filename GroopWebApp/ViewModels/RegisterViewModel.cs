﻿using System.ComponentModel.DataAnnotations;

namespace GroopWebApp.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Email address is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password do not mach")]
        public string ConfirmPassword { get; set; }
    }
}
