namespace TodoList2.Models;

public abstract class Entity<TId>
{
    protected Entity()
    {
        
    }

    protected Entity(TId ıd)
    {
        Id = ıd;
    }

    public TId Id { get; set; }
}
