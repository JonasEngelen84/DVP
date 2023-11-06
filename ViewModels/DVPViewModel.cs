using DVP.Stores;
using System.Windows.Input;

namespace DVP.ViewModels
{
    public class DVPViewModel
    {
        public EmployeesListViewViewModel EmployeesDetailsViewModel { get; }
        public ClothesListViewViewModel ClothesDetailsViewModel { get; }

        public ICommand FilterDataGridCommand { get; }
        public ICommand EditModelsCommand { get; }
        public ICommand BackwardCommand { get; }
        public ICommand SafeCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ContactCommand { get; }
        public ICommand EditPlusCommand { get; }
        public ICommand EditMinusCommand { get; }

        public DVPViewModel(SelectedClothesStore _selectedClothesStore)
        {
            ClothesDetailsViewModel = new ClothesListViewViewModel(_selectedClothesStore);
            EmployeesDetailsViewModel = new EmployeesListViewViewModel(_selectedClothesStore);
        }
    }
}
