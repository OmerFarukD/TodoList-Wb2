using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList2.Models
{
    public class Category : Entity<int>
    {
        public string Name { get; set; }
    }
}
