using TodoList2.Models;

namespace TodoList2.Repository;

public class BaseRepository
{
    List<Todo> todos = new List<Todo>()
    {
        new Todo()
        {
            //Id = 1,
            Description = "Fizik Ödevi Yapılaak",
            EndDate = new DateTime(2024,10,10),
            StartDate = new DateTime(2024,9,26),
            IsCompleted = false,
            Priority = "Çok Yüksek Öncelikli",
            Title = "Fizik Ödevi",
            UserId = 1
        }
    };

    List<User> users = new List<User>()
    {
        new User()
        {
            Id=1,
            Age= 25,
            Email = "deneme@gmail.com",
            Name = "deneme",
            Surname = "Doğan",
            Password = "12345689"
        }
    };

    protected List<User> Users() { return users; }
    protected List<Todo> Todos() { return todos; }
}
