using DVP.Stores;
using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für EmployeesDetailsComponent.xaml
    /// </summary>
    public partial class EmployeesDetailsComponent : UserControl
    {
        private readonly EmployeesListViewViewModel _employeesListViewViewModel;

        public EmployeesDetailsComponent()
        {
            InitializeComponent();

            _employeesListViewViewModel = new EmployeesListViewViewModel(new SelectedClothesStore());

            //this.DataContext = _employeesListViewViewModel;

            EmployeesListView.ItemsSource = _employeesListViewViewModel.AllEmployeeClothesCollection;
        }
    }
}
