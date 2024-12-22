using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Model.Context;

namespace SocialMedia.Model
{
    public class SignInResponse : BasicResponse
    {
        public User data {  get; set; } = new User();
    }
}
