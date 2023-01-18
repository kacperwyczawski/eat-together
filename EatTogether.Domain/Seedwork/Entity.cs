namespace EatTogether.Domain.Seedwork;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; protected set; }

    protected Entity(Guid id) => Id = id;

    public bool Equals(Entity? other) => Equals((object?)other);

    public override bool Equals(object? obj) => obj is Entity entity && Id.Equals(entity.Id);

    public static bool operator ==(Entity left, Entity right) => Equals(left, right);

    public static bool operator !=(Entity left, Entity right) => !Equals(left, right);
    
    public override int GetHashCode() => Id.GetHashCode();
}