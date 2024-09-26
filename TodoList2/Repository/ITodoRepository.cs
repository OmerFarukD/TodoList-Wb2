using TodoList2.Models;

namespace TodoList2.Repository;

public interface ITodoRepository : IRepository<Todo, Guid>
{
    List<Todo> GetAllByTitleContains(string title);
}
