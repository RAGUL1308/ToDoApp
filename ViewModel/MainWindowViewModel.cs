using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ToDoApp.Model;
using ToDoApp.MVVM;
using ToDoApp.View;

namespace ToDoApp.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Todo> Todos { get; set; }

        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(),canexecute=> SelectedItem!=null);

        public ICommand ShowWindowCommand { get; set; }


        private void DeleteItem()
        {
            Todos.Remove(SelectedItem);
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
            Todos = TodoManager.GetAll();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);

        }

        private bool CanShowWindow(object arg)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            GetTaskDetails addwindow = new GetTaskDetails();
            var mainwindow = obj as Window;
            addwindow.Owner = mainwindow;
            addwindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addwindow.Show();


        }
    }
}
