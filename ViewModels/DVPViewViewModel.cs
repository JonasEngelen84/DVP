using DVP.Models;
using DVP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DVP.ViewModels
{
    internal class DVPViewViewModel
    {
        public EmployeesDetailsComponentViewModel EmployeesDetailsViewModel { get; }
        public ClothesDetailsComponentViewModel ClothesDetailsViewModel { get; }
        public ClothesCollectionProvider _clothesCollectionProvider = new ClothesCollectionProvider();

        public ICommand FilterDataGridCommand { get; }
        public ICommand EditModelsCommand { get; }
        public ICommand BackwardCommand { get; }
        public ICommand SafeCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ContactCommand { get; }
        public ICommand EditPlusCommand { get; }
        public ICommand EditMinusCommand { get; }

        public DVPViewViewModel()
        {
            _clothesCollectionProvider.AddToClothesCollection(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 12, 19.99));
            _clothesCollectionProvider.AddToClothesCollection(new Clothes("Shirt", "Wintershirt", "M", "Winter", 8, 19.99));
            _clothesCollectionProvider.AddToClothesCollection(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 10, 50.29));
        }
        
    }
}
