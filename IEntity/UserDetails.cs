using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IEntity
{
    public class UserDetails
    {
        [Required(ErrorMessage = "Name can not be blank.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email-ID can not be blank.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Password can not be blank.")]
        public string Password { get; set; }
    }
}
