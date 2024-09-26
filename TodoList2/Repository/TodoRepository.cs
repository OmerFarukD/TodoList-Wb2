using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList2.Models;

namespace TodoList2.Repository
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {
        public Todo Add(Todo item)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllByTitleContains(string title)
        {
            throw new NotImplementedException();
        }

        public Todo? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Todo Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
