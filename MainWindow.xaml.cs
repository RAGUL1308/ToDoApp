using System.Windows;
using ToDoApp.ViewModel;

namespace ToDoApp
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainWindowViewModel mainViewModel = new MainWindowViewModel();
            this.DataContext = mainViewModel;
        }
    }
}