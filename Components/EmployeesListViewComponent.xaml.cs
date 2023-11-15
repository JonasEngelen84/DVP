using DVP.Stores;
using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für EmployeesListViewComponent.xaml
    /// </summary>
    public partial class EmployeesListViewComponent : UserControl
    {
        public EmployeesListViewComponent()
        {
            InitializeComponent();

            this.DataContext = new EmployeesListViewViewModel(new SelectedClothesStore());
        }
    }
}
