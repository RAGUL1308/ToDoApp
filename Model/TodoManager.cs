using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class TodoManager
    {
        private static string filePath = @"D:\Projects\ToDoApp\SourceData\Todos.json";

        public static ObservableCollection<Todo> GetAll()
        {
            if (!File.Exists(filePath))
            {
                return new ObservableCollection<Todo>();
            }

            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<ObservableCollection<Todo>>(json);
        }

        public static void AddTodo(Todo todo)
        {
            var todos = GetAll();
            todos.Add(todo);
            var json = JsonConvert.SerializeObject(todos, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static void DeleteTodo(Todo todo)
        {
            var todos = GetAll();
            var itemToRemove = todos.FirstOrDefault(r => r.Title == todo.Title && r.Description == todo.Description);
            todos.Remove(itemToRemove);
            var json = JsonConvert.SerializeObject(todos, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
        
    }
}
