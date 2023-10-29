using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für ClothesDetailsComponent.xaml
    /// </summary>
    public partial class ClothesDetailsComponent : UserControl
    {
        public ClothesDetailsComponent()
        {
            InitializeComponent();

            this.DataContext = new ClothesDetailsComponentViewModel();

            ClothesDetailsDataGrid.ItemsSource = ClothesDetailsComponentViewModel.ClothesCollection;
        }
    }
}
