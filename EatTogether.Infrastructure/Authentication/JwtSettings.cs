namespace EatTogether.Infrastructure.Authentication;

#nullable disable

public class JwtSettings
{
    public const string SectionName = "JwtSettings";
    public string Issuer { get; init; }
    public string Audience { get; init; }
    public int MinutesToExpire { get; init; }
    public string Secret { get; init; }
}