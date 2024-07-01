
using BluperDinner.Aplication.Common.Errors;
using BluperDinner.Aplication.Services.Authentication;
using BluperDinner.Contracts.Authentication;
using ErrorOr;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BluperDinner.API.Controllers;


[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly Aplication.Services.Authentication.IAuthenticationService _authenticationService;

    public AuthenticationController(Aplication.Services.Authentication.IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        ErrorOr<AuthenticationResult> registerResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
        
        return registerResult.Match(
            authResult => Ok(MapAuthResult(authResult)),
            errors => Problem(errors)
        );                          
       
    }

    private static AuthenticationResponse MapAuthResult(AuthenticationResult authResult)
    {
        return new AuthenticationResponse(
        authResult.User.Id.Value,
        authResult.User.FirstName,
        authResult.User.LastName,
        authResult.User.Email,
        authResult.Token
        );
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
         var authResutl = _authenticationService.Login(request.Email,request.Password);

         if (authResutl.IsError && authResutl.FirstError == Domain.Common.Errors.Authentication.InvalidCredentials) {
            return Problem(
                statusCode: StatusCodes.Status401Unauthorized,
                title: authResutl.FirstError.Description);
            };

         return authResutl.Match(
             authResult => Ok(MapAuthResult(authResult)),
             errors => Problem(errors)
         ); 
       
    }
}