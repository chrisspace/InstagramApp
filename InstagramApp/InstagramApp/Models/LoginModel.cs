using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace InstagramApp.Models
{
    public class LoginModel
    {
        [Required, MaxLength(20), EmailAddress]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }

    }
}
