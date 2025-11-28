using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormProcessing.Models
{
    public class Login
    {
        [Required]
        [StringLength(20, MinimumLength = 3)] //Maximum length of 20 characters
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)] //Minimum length of 4 characters
        public string Password { get; set; }
    }
}