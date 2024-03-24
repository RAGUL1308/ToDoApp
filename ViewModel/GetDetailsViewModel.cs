using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ToDoApp.Model;
using ToDoApp.MVVM;

namespace ToDoApp.ViewModel
{
   public class GetDetailsViewModel : BaseViewModel
    {

        public RelayCommand AddToDoCommand => new RelayCommand(execute => AddTodo(), canexecute => { return true; });

        private void AddTodo()
        {
            TodoManager.AddTodo(new Todo { Title = Title, Description = Description, IsCompleted = false });
            

        }


        private string _title;
        private string _description;
        public string Title {
            get { return _title; }
            set {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }    
            }
        }
       
           public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged();
                }
            }
        }
    
    }
}
