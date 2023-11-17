using DVP.Commands;
using DVP.Stores;
using System.Windows.Input;

namespace DVP.ViewModels
{
    /// <summary>
    /// Interaktionslogik für DVPView.xaml:
    /// </summary>
    public class DVPViewModel : ViewModelBase
    {
        public EmployeesListViewViewModel EmployeesDetailsViewModel { get; }
        public ClothesListViewViewModel ClothesDetailsViewModel { get; }

        public ICommand FilterListViewCommand { get; }
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
            FilterListViewCommand = new FilterListViewCommand(this);
        }
    }
}
