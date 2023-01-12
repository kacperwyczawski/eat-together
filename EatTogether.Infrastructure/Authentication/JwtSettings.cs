namespace EatTogether.Infrastructure.Authentication;

#nullable disable

public class JwtSettings
{
    public string Issuer { get; init; }
    public string Audience { get; init; }
    public int MinutesToExpire { get; init; }
    public string SecretKey { get; init; }
}