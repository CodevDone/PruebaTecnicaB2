namespace BluperDinner.Aplication.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "fistName",
            "lastName",
            email,
            "token"
        );
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token"
        );
    }
}