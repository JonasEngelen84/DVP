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
        private readonly ClothesListViewViewModel _clothesListViewViewModel;

        public ClothesDetailsComponent()
        {
            InitializeComponent();

            _clothesListViewViewModel = new ClothesListViewViewModel(new SelectedClothesStore());

            //this.DataContext = _clothesListViewViewModel;

            ClothesListView.ItemsSource = _clothesListViewViewModel.ClothesCollection;
        }
    }
}
