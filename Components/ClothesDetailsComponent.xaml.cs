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
            ClothesDetailsComponentViewModel _clothesDetailsComponentViewModel;

            InitializeComponent();
            _clothesDetailsComponentViewModel = new ClothesDetailsComponentViewModel();
            this.DataContext = new ClothesDetailsComponentViewModel();
            ClothesDetailsDataGrid.ItemsSource = _clothesDetailsComponentViewModel.ClothesCollection;
        }
    }
}
