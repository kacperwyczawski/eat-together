namespace EatTogether.Domain.Features.MealAggregate.ValueObjects;

public class Address : ValueObject
{
    public string Street { get; }
    public string City { get; }
    public string Country { get; }
    public float Latitude { get; }
    public float Longitude { get; }
        
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street.ToUpperInvariant();
        yield return City.ToUpperInvariant();
        yield return Country.ToUpperInvariant();
        yield return Math.Round(Latitude, 6);
        yield return Math.Round(Longitude, 6);
    }
}