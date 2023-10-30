using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für EmployeesDetailsComponent.xaml
    /// </summary>
    public partial class EmployeesDetailsComponent : UserControl
    {
        public EmployeesDetailsComponentViewModel _employeesDetailsComponentViewModel;

        public EmployeesDetailsComponent()
        {
            InitializeComponent();
            _employeesDetailsComponentViewModel = new EmployeesDetailsComponentViewModel();
            this.DataContext = _employeesDetailsComponentViewModel;
            EmployeesDetailsDataGrid.ItemsSource = _employeesDetailsComponentViewModel.AllEmployeeClothesCollection;
        }
    }
}
