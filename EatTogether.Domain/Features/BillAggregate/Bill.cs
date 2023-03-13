using EatTogether.Domain.Shared.ValueObjects;

namespace EatTogether.Domain.Features.BillAggregate;

public sealed class Bill : AggregateRoot
{
    private readonly Guid _mealId;
    private readonly Guid _guestId;
    public readonly Guid HostId;

    public Price Price { get; }

    public Bill(Guid id, Price price, DateTime createdAt, DateTime updatedAt, Guid mealId, Guid guestId, Guid hostId)
        : base(id, createdAt, updatedAt)
    {
        Price = price;
        _mealId = mealId;
        _guestId = guestId;
        HostId = hostId;
    }
}