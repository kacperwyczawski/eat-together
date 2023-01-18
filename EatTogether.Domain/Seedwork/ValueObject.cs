namespace EatTogether.Domain.Seedwork;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetEqualityComponents();

    public bool Equals(ValueObject? other) => Equals((object?)other);

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;

        var valueObject = (ValueObject)obj;

        return GetEqualityComponents()
            .SequenceEqual(valueObject.GetEqualityComponents());
    }

    public override int GetHashCode() =>
        GetEqualityComponents()
            .Select(obj => obj?.GetHashCode() ?? 0)
            .Aggregate((a, b) => a ^ b);

    public static bool operator ==(ValueObject? left, ValueObject? right) => Equals(left, right);

    public static bool operator !=(ValueObject? left, ValueObject? right) => !Equals(left, right);
}

public class Price : ValueObject
{
    public decimal Amount { get; private set; }
    public string Currency { get; private set; }

    public Price(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}