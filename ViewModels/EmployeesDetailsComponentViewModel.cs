using DVP.Models;
using DVP.Stores;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DVP.ViewModels
{
    public class EmployeesDetailsComponentViewModel : ViewModelBase
    {
        private ObservableCollection<Clothes> _allEmployeeClothesCollection;

        // Zur encapsulation von _allEmployeeClothesCollection wird ein IEnumerable als pointer verwendet.
        public IEnumerable<Clothes> AllEmployeeClothesCollection => _allEmployeeClothesCollection;

        public EmployeesDetailsComponentViewModel(SelectedClothesStore _selectedClothesStore)
        {
            _allEmployeeClothesCollection = new ObservableCollection<Clothes>
            {
                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 4, 666, "Jonas", "Engelen"),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 2, 666, "Jonas", "Engelen"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 3, 666, "Jonas", "Engelen"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 2, 666, "Jonas", "Engelen"),
                new Clothes("Jacke", "Regenjacke", "L", "", 1, 666, "Jonas", "Engelen"),
                new Clothes("Jacke", "Fleecejacke", "S", "", 1, 666, "Jonas", "Engelen"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 666, "Jonas", "Engelen"),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1, 666, "Jonas", "Engelen"),
                new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1, 666, "Jonas", "Engelen"),

                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2, 132, "Markus", "Oettken"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2, 132, "Markus", "Oettken"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 2, 132, "Markus", "Oettken"),
                new Clothes("Jacke", "Regenjacke", "L", "", 1, 132, "Markus", "Oettken"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 132, "Markus", "Oettken"),

                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 1, 456, "Nadine", "Molik"),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 1, 456, "Nadine", "Molik"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 1, 456, "Nadine", "Molik"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 1, 456, "Nadine", "Molik"),
                new Clothes("Jacke", "Regenjacke", "L", "", 1, 456, "Nadine", "Molik"),
                new Clothes("Jacke", "Fleecejacke", "S", "", 1, 456, "Nadine", "Molik"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 456, "Nadine", "Molik"),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1, 456, "Nadine", "Molik"),
                new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1, 456, "Nadine", "Molik"),

                new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2, 798, "Daniel", "Nickol"),
                new Clothes("Shirt", "Wintershirt", "M", "Winter", 2, 798, "Daniel", "Nickol"),
                new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2, 798, "Daniel", "Nickol"),
                new Clothes("Hose", "Winterhose", "L", "Winter", 2, 798, "Daniel", "Nickol"),
                new Clothes("Jacke", "Regenjacke", "L", "", 2, 798, "Daniel", "Nickol"),
                new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2, 798, "Daniel", "Nickol"),
                new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 2, 798, "Daniel", "Nickol")
            };
        }
    }
}
