using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList2.Models;

namespace TodoList2.Repository
{
    public interface ICategoryRepository : IRepository<Category, int>
    {
    }
}
