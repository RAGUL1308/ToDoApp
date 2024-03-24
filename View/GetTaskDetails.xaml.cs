using System.Windows;
using ToDoApp.ViewModel;

namespace ToDoApp.View
{

    public partial class GetTaskDetails : Window
    {
        public GetTaskDetails()
        {
            InitializeComponent();
            GetDetailsViewModel getNewTaskViewModel= new GetDetailsViewModel();
            this.DataContext =getNewTaskViewModel ;
        }
    }
}
