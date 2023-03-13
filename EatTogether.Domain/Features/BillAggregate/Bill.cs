using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.BillAggregate;

public sealed class Bill : AggregateRoot
{
    private readonly Guid _mealId;
    private readonly Guid _guestId;
    public readonly Guid HostId;

    public Price Price { get; }

    public Bill(Price price, Guid mealId, Guid guestId, Guid hostId)
    {
        Price = price;
        _mealId = mealId;
        _guestId = guestId;
        HostId = hostId;
    }
}