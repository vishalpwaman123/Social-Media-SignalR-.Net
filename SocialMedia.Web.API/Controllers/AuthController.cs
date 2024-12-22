using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Model;
using SocialMedia.Repository.Interface;

namespace SocialMedia.Web.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository) => _authRepository = authRepository;

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpRequest request)
        {
            var response = await _authRepository.SignUp(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInRequest request)
        {
            var response = await _authRepository.SignIn(request);
            return Ok(response);
        }

    }
}
