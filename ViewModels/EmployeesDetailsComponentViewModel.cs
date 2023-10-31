using DVP.Models;
using DVP.Stores;
using System.Collections.ObjectModel;

namespace DVP.ViewModels
{
    public class EmployeesDetailsComponentViewModel : ViewModelBase
    {
        public ObservableCollection<Employee> EmployeeCollection { get; set; }
        public ObservableCollection<Clothes> AllEmployeeClothesCollection { get; set; }

        public EmployeesDetailsComponentViewModel(SelectedEmployeeStore _selectedEmployeeStore)
        {
            EmployeeCollection = new ObservableCollection<Employee>();
            AllEmployeeClothesCollection = new ObservableCollection<Clothes>();

            Employee jonas = new Employee(666, "Jonas", "Engelen");
            EmployeeCollection.Add(jonas);
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 4, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 2, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 3, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 2, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Regenjacke", "L", "", 1, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Fleecejacke", "S", "", 1, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1, 666, "Jonas", "Engelen"));
            AllEmployeeClothesCollection.Add(new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1, 666, "Jonas", "Engelen"));

            Employee markus = new Employee(123, "Markus", "Oettken");
            EmployeeCollection.Add(markus);
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2, 132, "Markus", "Oettken"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2, 132, "Markus", "Oettken"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 2, 132, "Markus", "Oettken"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Regenjacke", "L", "", 1, 132, "Markus", "Oettken"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 132, "Markus", "Oettken"));

            Employee nadine = new Employee(456, "Nadine", "Molik");
            EmployeeCollection.Add(nadine);
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Regenjacke", "L", "", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Fleecejacke", "S", "", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1, 456, "Nadine", "Molik"));
            AllEmployeeClothesCollection.Add(new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1, 456, "Nadine", "Molik"));

            Employee daniel = new Employee(789, "Daniel", "Nickol");
            EmployeeCollection.Add(daniel);
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2, 798, "Daniel", "Nickol"));
            AllEmployeeClothesCollection.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 2, 798, "Daniel", "Nickol"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2, 798, "Daniel", "Nickol"));
            AllEmployeeClothesCollection.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 2, 798, "Daniel", "Nickol"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Regenjacke", "L", "", 2, 798, "Daniel", "Nickol"));
            AllEmployeeClothesCollection.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2, 798, "Daniel", "Nickol"));
            AllEmployeeClothesCollection.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 2, 798, "Daniel", "Nickol"));

        }
    }
}
