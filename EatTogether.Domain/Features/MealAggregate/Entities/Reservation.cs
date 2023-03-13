using EatTogether.Domain.Features.MealAggregate.Enums;

namespace EatTogether.Domain.Features.MealAggregate.Entities;

public class Reservation : Entity
{
    public int GuestCount { get; }
    public ReservationStatus Status { get; }
    
    public Reservation(Guid id, ReservationStatus status, int guestCount) : base(id)
    {
        Status = status;
        GuestCount = guestCount;
    }
}