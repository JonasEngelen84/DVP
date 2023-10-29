using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für EmployeesDetailsComponent.xaml
    /// </summary>
    public partial class EmployeesDetailsComponent : UserControl
    {
        public EmployeesDetailsComponent()
        {
            InitializeComponent();

            this.DataContext = new EmployeesDetailsComponentViewModel();

            EmployeesDetailsDataGrid.ItemsSource = EmployeesDetailsComponentViewModel.EmployeeCollection;
        }
    }
}
