namespace EatTogether.Domain.Seedwork;

public class AggregateRoot : Entity
{
    protected AggregateRoot()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
    
    public DateTime CreatedAt { get; }
    
    public DateTime UpdatedAt { get; }
}