using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using IEntity;

namespace MVCApplication.Models
{
    public class UserMaster
    {
        [Required(ErrorMessage = "First name can not be blank.")]
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [Required(ErrorMessage = "User name can not be blank.")]
        public string Username { get; set; }
        public string Address { get; set; }

        [Required(ErrorMessage = "Email-ID can not be blank.")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Email-ID can not be blank.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Password can not be blank.")]
        public string Password { get; set; }
    }
}