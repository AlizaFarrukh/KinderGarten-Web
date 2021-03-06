﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.Extended
{
    [MetadataType(typeof(UserMetadata))]
public class User
    {
        
    }

    public class UserMetadata
    {
        [DisplayAttribute(Name ="First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string FirstName { get; set; }

        [DisplayAttribute(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [DisplayAttribute(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage = "Minimum 6 characyers required")]
        public string Password { get; set; }

        [DisplayAttribute(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare( "Password" , ErrorMessage = "Confirm password and Password do not match")]
        public string ConfirmPassword { get; set; }


    }

}