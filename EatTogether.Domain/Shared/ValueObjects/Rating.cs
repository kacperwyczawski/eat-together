namespace EatTogether.Domain.Shared.ValueObjects;

public class Rating : ValueObject
{
    private readonly float _value;

    private Rating(float value)
    {
        if (value is < 1 or > 5)
            throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 1 and 5");

        _value = value;
    }

    public static Rating FromFloat(float value) => new Rating(value);

    public static Rating FromInt(int value) => new Rating(value);

    public static implicit operator float(Rating rating) => rating._value;

    public static implicit operator int(Rating rating) => (int)rating._value;

    /// <example>4.5/5</example>
    public override string ToString() => $"{_value:0.0}/5";

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Math.Round(_value, 1);
    }

    public static Rating Average(IEnumerable<Rating> ratings) => Rating.FromFloat(ratings.Average(r => (float)r));
}