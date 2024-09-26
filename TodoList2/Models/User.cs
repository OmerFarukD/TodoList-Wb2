namespace TodoList2.Models;

public class User : Entity<long>
{
    public User()
    {
   
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Age { get; set; }
}
