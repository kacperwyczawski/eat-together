namespace EatTogether.Domain.Seedwork;

public class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id, DateTime createdAt, DateTime updatedAt) : base(id)
    {
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }
    
    public DateTime CreatedAt { get; }
    
    public DateTime UpdatedAt { get; }
}