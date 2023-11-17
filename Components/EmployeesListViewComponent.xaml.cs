using DVP.Stores;
using DVP.ViewModels;
using System.Windows.Controls;

namespace DVP.Components
{
    /// <summary>
    /// Interaktionslogik für EmployeesListViewComponent.xaml
    /// Wird wie alle anderen Views durch DataContext übergangen
    /// auf die selbst angelegte Klasse "EmployeesListViewViewModel".
    /// </summary>
    public partial class EmployeesListViewComponent : UserControl
    {
        public EmployeesListViewComponent()
        {
            InitializeComponent();

            DataContext = new EmployeesListViewViewModel(new SelectedClothesStore());
        }
    }
}
