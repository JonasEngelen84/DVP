using DVP.Stores;
using System.Windows.Input;

namespace DVP.ViewModels
{
    public class DVPViewViewModel
    {
        public EmployeesDetailsComponentViewModel EmployeesDetailsViewModel { get; }
        public ClothesDetailsComponentViewModel ClothesDetailsViewModel { get; }

        public ICommand FilterDataGridCommand { get; }
        public ICommand EditModelsCommand { get; }
        public ICommand BackwardCommand { get; }
        public ICommand SafeCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ContactCommand { get; }
        public ICommand EditPlusCommand { get; }
        public ICommand EditMinusCommand { get; }

        public DVPViewViewModel(SelectedClothesStore _selectedClothesStore)
        {
            ClothesDetailsViewModel = new ClothesDetailsComponentViewModel(_selectedClothesStore);
            EmployeesDetailsViewModel = new EmployeesDetailsComponentViewModel(_selectedClothesStore);
        }
    }
}
