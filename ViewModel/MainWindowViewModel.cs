using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToDoApp.Model;
using ToDoApp.MVVM;

namespace ToDoApp.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Todo> Todos { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem(), canexecute => { return true; });
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(),canexecute=> SelectedItem!=null);

        private void DeleteItem()
        {
            Todos.Remove(SelectedItem);
        }

        private void AddItem()
        {
           
            Todos.Add(new Todo { Title="DefaultTask", Description="Defalut Description",IsCompleted=false});
        }

        private Todo _selectedItem;

        public Todo SelectedItem
        {
            get { return _selectedItem; }
            set { 
                _selectedItem = value;
                OnPropertyChanged();

            }
        }

        public MainWindowViewModel()
        {
            Todos = new ObservableCollection<Todo>();
          /*  Todos.Add(new Todo { Title = "XXX", Description = "YYYYY" });
            Todos.Add(new Todo { Title = "ZZZ", Description ="wfasvafsvdfv" });*/
        }
    }
}
