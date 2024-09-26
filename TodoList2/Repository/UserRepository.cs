using TodoList2.Models;

namespace TodoList2.Repository;

public class UserRepository : BaseRepository, IUserRepository
{
    public User Add(User item)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        throw new NotImplementedException();
    }

    public User? GetById(long id)
    {
        throw new NotImplementedException();
    }

    public User Remove(long id)
    {
        throw new NotImplementedException();
    }
}
