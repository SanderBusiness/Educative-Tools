namespace Domain.Abstract;

public abstract class Entity
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;
}