using DVP.ViewModels;
using System.Windows;

namespace DVP
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new DVPViewViewModel()
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
