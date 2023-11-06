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
        private readonly SelectedClothesStore _selectedClothesStore;

        public App()
        {
            _selectedClothesStore = new SelectedClothesStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new DVPViewModel(_selectedClothesStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
