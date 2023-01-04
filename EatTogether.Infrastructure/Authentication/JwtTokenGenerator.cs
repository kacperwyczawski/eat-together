using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using EatTogether.Application.Common.Interfaces;

namespace EatTogether.Infrastructure.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingKey = new SymmetricSecurityKey("it's:very:secret"u8.ToArray());
        
        var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var securityToken = new JwtSecurityToken(
            issuer: "EatTogether",
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: signingCredentials,
            claims: claims);
        
        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}