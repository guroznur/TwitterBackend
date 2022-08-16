using Core.Utilities.Result.Abstract;
using Core.Utilities.Security.JWT;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<IResult> Register(RegisterAuthDto registerDto);
        Task<IDataResult<Token>> Login(LoginAuthDto loginDto);
        Task<IDataResult<Token>> GoogleLogin(GoogleLoginAuthDto googleLoginDto);
        Task<IDataResult<Token>> FacebookLogin(FacebookLoginAuthDto facebookLoginDto);
        Task<IDataResult<Token>> TwitterLogin(TwitterLoginAuthDto twitterLoginDto);

    }
}
