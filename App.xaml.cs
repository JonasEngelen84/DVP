using DVP.Stores;
using DVP.ViewModels;
using System.Windows;

namespace DVP
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedEmployeeStore _selectedEmployeeStore;

        public App()
        {
            _selectedEmployeeStore= new SelectedEmployeeStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new DVPViewViewModel(_selectedEmployeeStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
