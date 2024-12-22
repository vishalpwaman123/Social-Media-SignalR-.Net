using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Model;
using SocialMedia.Model.Constant;
using SocialMedia.Model.Context;
using SocialMedia.Repository.Interface;

namespace SocialMedia.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public AuthRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
        public async Task<SignInResponse> SignIn(SignInRequest request)
        {
            try
            {
                var result = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == request.Email.ToLower() && x.Password == request.Password);
                if (result is not null)
                {
                    SignInResponse response = new SignInResponse() { data = result };
                    response.data.Password = string.Empty;
                    return response;
                }
                else
                    return new SignInResponse()
                    {
                        IsSuccess = false,
                        Message = Constant.UNAUTHENTICATED_USER
                    };

            }
            catch (Exception ex)
            {
                return new SignInResponse()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<BasicResponse> SignUp(SignUpRequest request)
        {
            try
            {
                User user = new User()
                {
                    Email = request.Email,
                    Password = request.Password
                };
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
                return new BasicResponse();
            }
            catch (Exception ex)
            {
                return new BasicResponse()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
