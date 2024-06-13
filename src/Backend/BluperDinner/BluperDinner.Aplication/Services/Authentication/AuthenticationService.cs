using BluperDinner.Aplication.Interfaces.Authentication;
using BluperDinner.Aplication.Interfaces.Persistence;
using BluperDinner.Domain.Entities;
using BluperDinner.Aplication.Common;
using ErrorOr;
using BluperDinner.Domain.Common;

namespace BluperDinner.Aplication.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthenticationResult> Login(string email, string password)
    {
        // 1. Validate the user exist
          
        if (_userRepository.GetUserByEmail(email) is not User user)
        {
            return Errors.Authentication.InvalidCredentials;
        }
        // 2. Validate the password is correct 
        if (user.Pasword != password)
        {
            return Errors.Authentication.InvalidCredentials;;
        }
        // 3. Create  JWT token

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
           user,
            token
        );
    }


    public ErrorOr<AuthenticationResult> Register(string FirstName, string LastName, string Email, string Password)
    {
         // 1 validate the user doesn't exist
        if (_userRepository.GetUserByEmail(Email) is not null)
        {
            return  Errors.User.DuplicateEmail;
        }

        // 2 Create User (generate unique Id & persist)

        var user = new User{
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            Pasword = Password
        };
        _userRepository.Add(user);

        // 3 create jwt token
         
        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
        );
    }
}