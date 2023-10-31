using DVP.Models;
using DVP.Stores;
using System.Collections.ObjectModel;

namespace DVP.ViewModels
{
    public class ClothesDetailsComponentViewModel : ViewModelBase
    {
        public ObservableCollection<Clothes> ClothesCollection { get; set; }

        public ClothesDetailsComponentViewModel(SelectedEmployeeStore _selectedEmployeeStore)
        {
            ClothesCollection = new ObservableCollection<Clothes>();

            ClothesCollection.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 12, 19.99));
            ClothesCollection.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 8, 19.99));
            ClothesCollection.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 10, 50.29));
            ClothesCollection.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 6, 19.99));
            ClothesCollection.Add(new Clothes("Jacke", "Regenjacke", "L", "", 12, 25.99));
            ClothesCollection.Add(new Clothes("Jacke", "Fleecejacke", "S", "", 7, 25.99));
            ClothesCollection.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2, 45.99));
            ClothesCollection.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 8, 10.99));
            ClothesCollection.Add(new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 4, 15.99));
        }
    }
}
