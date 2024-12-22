using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Model;

namespace SocialMedia.Repository.Interface
{
    public interface IAuthRepository
    {
        Task<SignInResponse> SignIn(SignInRequest request);
        Task<BasicResponse> SignUp(SignUpRequest request);
    }
}
