
using BluperDinner.Aplication.Services.Authentication;
using BluperDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BluperDinner.API.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResutl = _authenticationService.Register(request.FirstName,request.LastName,request.Email,request.Password);
        
        var response = new AuthenticationResponse(
            authResutl.id,
            authResutl.FirstName,
            authResutl.LastName,
            authResutl.Email,
            authResutl.Token
            );
        
        return Ok(response);
    }
    
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
         var authResutl = _authenticationService.Login(request.Email,request.Password);
        
        var response = new AuthenticationResponse(
            authResutl.id,
            authResutl.FirstName,
            authResutl.LastName,
            authResutl.Email,
            authResutl.Token
            );
        
        return Ok(response);
    }
}