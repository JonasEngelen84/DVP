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
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 8, 19.99),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 10, 50.29),
                new Clothes("Hose", "Winterhose", "L", "Winter", 6, 19.99),
                new Clothes("Jacke", "Regenjacke", "L", "", 12, 25.99),
                new Clothes("Jacke", "Fleecejacke", "S", "", 7, 25.99),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2, 45.99),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 8, 10.99),
                new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 4, 15.99)
            };
        }
    }
}
