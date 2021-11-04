﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models.Authentication
{
    public class Register
    {
        [Required]
        public string Username{ get; set; }

        [EmailAddress,Required,Display(Name = "Email address")]
        public string EmailAddress{ get; set; }

        [Required,DataType(DataType.Password)]
        public string Password{ get; set; }

        [Compare("Password",ErrorMessage ="Passwords don't match"),Display(Name = "Confirm")]
        public string ConfirmPassword{ get; set; }
    }
}
