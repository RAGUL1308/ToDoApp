using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class TodoManager
    {
        private static ObservableCollection<Todo> _databaseTodos = new ObservableCollection<Todo>()
        {
            new Todo{Title="Wake Up", Description="Use morning time", IsCompleted=false},
            new Todo{Title="Exercise", Description="Reduce My weight", IsCompleted=false},
            new Todo{Title="Breakfast", Description="Gives the energy for whole day", IsCompleted=false},
            new Todo{Title="Read Newspaper", Description="Update the new Information", IsCompleted=false},
            new Todo{Title="Journal", Description="Write the most priority tasks of today", IsCompleted=false},
        };

        public static ObservableCollection<Todo> GetAll()
        {
            return _databaseTodos;
        }

        public static void AddTodo(Todo todo)
        {
            _databaseTodos.Add(todo);
        }

    
     
    }
}
