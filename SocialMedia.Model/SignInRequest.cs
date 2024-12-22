using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Model
{
    public class SignInRequest
    {
        [EmailAddress, Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
