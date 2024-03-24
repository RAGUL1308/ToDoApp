using System.Windows;
using ToDoApp.Model;
using ToDoApp.ViewModel;

namespace ToDoApp.View
{

    public partial class GetTaskDetails : Window
    {
        private MainWindowViewModel mainWindowViewModel;

        public GetTaskDetails(MainWindowViewModel viewModel)
        {
            InitializeComponent();
            mainWindowViewModel = viewModel;
            DataContext = new GetDetailsViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as GetDetailsViewModel;
            if (viewModel != null)
            {
                TodoManager.AddTodo(new Todo { Title = viewModel.Title, Description = viewModel.Description, IsCompleted = false });
                DialogResult = true;
              
            }
        }

    }
}

