using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.Bill;

public sealed class Bill : AggregateRoot
{
    public Price Price { get; }
    
    protected Bill(Guid id, Price price) : base(id)
    {
        Price = price;
    }
}