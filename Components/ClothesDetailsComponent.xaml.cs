using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für ClothesDetailsComponent.xaml
    /// </summary>
    public partial class ClothesDetailsComponent : UserControl
    {
        //private ClothesDetailsComponentViewModel _clothesDetailsComponentViewModel;

        public ClothesDetailsComponent()
        {
            InitializeComponent();
            
            //_clothesDetailsComponentViewModel = new ClothesDetailsComponentViewModel();
            
            //ClothesDetailsDataGrid.ItemsSource = _clothesDetailsComponentViewModel.ClothesCollection;
        }
    }
}
