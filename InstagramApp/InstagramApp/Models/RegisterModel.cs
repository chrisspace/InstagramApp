using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InstagramApp.Models
{
    public class RegisterModel
    {
        //private string _firstname { get; set; }
        //private string _lastname { get; set; }
        //private string _password { get; set; }
        //private string _confirmPassword { get; set; }
        //private string _email { get; set; }

        
        public string Firstname { get; set; }

        
        public string Lastname { get; set; }

        
        public string Password { get; set; }

        
        public string ConfirmPassword { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }


    }
}
