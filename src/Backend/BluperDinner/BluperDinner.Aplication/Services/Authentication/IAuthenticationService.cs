using BluperDinner.Aplication.Common.Errors;
using ErrorOr;

namespace BluperDinner.Aplication.Services.Authentication;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResult> Login (string Email,string Password );

    ErrorOr<AuthenticationResult>  Register (string FirstName,string LastName,string Email,string Password );
}