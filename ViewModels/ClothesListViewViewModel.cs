using DVP.Models;
using DVP.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DVP.ViewModels
{
    public class ClothesListViewViewModel : ViewModelBase
    {
        private readonly ObservableCollection<Clothes> _clothesCollection;

        // Zur encapsulation von _clothesCollection wird ein IEnumerable als pointer verwendet.
        public IEnumerable<Clothes> ClothesCollection => _clothesCollection;


        public ClothesListViewViewModel(SelectedClothesStore _selectedClothesStore)
        {
            _clothesCollection = new ObservableCollection<Clothes>
            {
                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 12, 19.99),
                new Clothes("Shirt", "Sommershirt", "L", "Sommer", 8, 19.99),
                new Clothes("Shirt", "Sommershirt", "M", "Sommer", 10, 19.99),
                new Clothes("Shirt", "Wintershirt", "XL", "Winter", 8, 19.99),
                new Clothes("Shirt", "Wintershirt", "L", "Winter", 5, 19.99),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 15, 19.99),
                new Clothes("Hose", "Sommerhose", "58", "Sommer", 6, 50.29),
                new Clothes("Hose", "Sommerhose", "55", "Sommer", 3, 50.29),
                new Clothes("Hose", "Sommerhose", "48", "Sommer", 11, 50.29),
                new Clothes("Hose", "Winterhose", "58", "Winter", 6, 19.99),
                new Clothes("Hose", "Winterhose", "55", "Winter", 10, 19.99),
                new Clothes("Hose", "Winterhose", "48", "Winter", 3, 19.99),
                new Clothes("Jacke", "Regenjacke", "XL", "", 12, 25.99),
                new Clothes("Jacke", "Regenjacke", "L", "", 7, 25.99),
                new Clothes("Jacke", "Regenjacke", "M", "", 5, 25.99),
                new Clothes("Jacke", "Fleecejacke", "L", "", 7, 25.99),
                new Clothes("Jacke", "Fleecejacke", "M", "", 8, 25.99),
                new Clothes("Jacke", "Fleecejacke", "S", "", 9, 25.99),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2, 45.99),
                new Clothes("Jacke", "Winterjacke", "L", "Winter", 5, 45.99),
                new Clothes("Jacke", "Winterjacke", "M", "Winter", 7, 45.99),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 8, 10.99),
                new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 4, 15.99)
            };
        }
    }
}
