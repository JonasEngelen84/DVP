using DVP.Stores;
using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für ClothesDetailsComponent.xaml
    /// </summary>
    public partial class ClothesDetailsComponent : UserControl
    {
        private readonly ClothesDetailsComponentViewModel _clothesDetailsComponentViewModel;

        public ClothesDetailsComponent()
        {
            InitializeComponent();

            _clothesDetailsComponentViewModel = new ClothesDetailsComponentViewModel(new SelectedClothesStore());

            this.DataContext = _clothesDetailsComponentViewModel;

            ClothesDetailsDataGrid.ItemsSource = _clothesDetailsComponentViewModel.ClothesCollection;
        }
    }
}
