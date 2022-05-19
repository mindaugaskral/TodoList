using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoSql.Models;

namespace TodoSql.Services
{
    public class TodosService
    {
        private List<Todo> _todos;

        public List<Todo> GetAll()
        {
            return _todos;
        }
    }
}
