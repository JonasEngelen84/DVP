using DVP.Stores;
using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für ClothesListViewComponent.xaml
    /// </summary>
    public partial class ClothesListViewComponent : UserControl
    {
        public ClothesListViewComponent()
        {
            InitializeComponent();

            this.DataContext = new ClothesListViewViewModel(new SelectedClothesStore());
        }
    }
}
