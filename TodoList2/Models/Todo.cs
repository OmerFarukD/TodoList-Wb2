
namespace TodoList2.Models;

public class Todo : Entity<Guid>
{
    public Todo()
    {
        CreatedDate = DateTime.Now; 
    }

    public Todo(int id,string title, string description, DateTime startDate, DateTime endDate, int userId, bool ısCompleted, string priority) :this()
    {
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        UserId = userId;
        IsCompleted = ısCompleted;
        Priority = priority;

       
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int UserId { get; set; }

    public bool IsCompleted { get; set; }
    public string Priority { get; set; }
}
