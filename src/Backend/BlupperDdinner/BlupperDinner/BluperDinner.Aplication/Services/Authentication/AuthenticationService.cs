using BluperDinner.Aplication.Interfaces.Authentication;
using BluperDinner.Aplication.Interfaces.Persistence;
using BluperDinner.Domain.Entities;

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

    public AuthenticationResult Login(string email, string password)
    {
        // 1. Validate the user exist
        User? user = _userRepository.GetUserByEmail(email);
        if (user is null)
        {
            throw new Exception("User does not exist.");
        }
        // 2. Validate the password is correct 
        if (user.Pasword != password)
        {
            throw new Exception("Invalid password.");
        }
        // 3. Create  JWT token

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
           user,
            token
        );
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // 1 validate the user doesn't exist
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User already exist");
        }

        // 2 Create User (generate unique Id & persist)

        var user = new User{
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Pasword = password
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