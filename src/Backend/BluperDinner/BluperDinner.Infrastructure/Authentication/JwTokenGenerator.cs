using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BluperDinner.Aplication.Interfaces.Authentication;
using BluperDinner.Aplication.Interfaces.Services;
using BluperDinner.Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BluperDinner.Infrastructure.Authentication
{
    public class JwTokenGenerator : IJwtTokenGenerator
    {

        private readonly IDateTimerProvider _dateTimeProvider;
        private readonly JwtSettings _jwtSettings;

        public JwTokenGenerator(IDateTimerProvider dateTimeProvider,IOptions<JwtSettings> jwtOptions)
        {
            _dateTimeProvider = dateTimeProvider;
            _jwtSettings = jwtOptions.Value;
        }

        public string GenerateToken(User user)
        {
            var siginingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
                SecurityAlgorithms.HmacSha256 );

            var claims = new []
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Id.Value.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName,user.FirstName),
                new Claim(JwtRegisteredClaimNames.FamilyName,user.LastName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
               
            };

            var securityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims:claims,
                expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
                signingCredentials: siginingCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}