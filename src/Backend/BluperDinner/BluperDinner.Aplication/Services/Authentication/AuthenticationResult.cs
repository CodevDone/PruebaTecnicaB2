using BluperDinner.Domain.Entities;

namespace BluperDinner.Aplication.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token 
);