using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Infrastructure.Security.TokenGenerator;

public class JwtGenerator(IOptions<JwtSettings> jwtSettings) : ITokenGenerator
{
    private readonly JwtSettings _jwtSettings = jwtSettings.Value;
    public string GenerateJwt(string id, string user_name, string email)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            _jwtSettings.Issuer,
            _jwtSettings.Audience,
            expires: DateTime.UtcNow.AddMinutes(_jwtSettings.TokenExpirationInMinutes),
            signingCredentials: credentials
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
        
    }
}
