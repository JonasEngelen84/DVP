using DVP.Models;
using System.Collections.ObjectModel;

namespace DVP.ViewModels
{
    internal class EmployeesDetailsComponentViewModel
    {
        public static ObservableCollection<Employee> EmployeeCollection { get; set; }

        public EmployeesDetailsComponentViewModel()
        {
            EmployeeCollection = new ObservableCollection<Employee>();

            Employee jonas = new Employee(666, "Jonas", "Engelen");
            jonas.EmployeeClothesList.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 4));
            jonas.EmployeeClothesList.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 2));
            jonas.EmployeeClothesList.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 3));
            jonas.EmployeeClothesList.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 2));
            jonas.EmployeeClothesList.Add(new Clothes("Jacke", "Regenjacke", "L", "", 1));
            jonas.EmployeeClothesList.Add(new Clothes("Jacke", "Fleecejacke", "S", "", 1));
            jonas.EmployeeClothesList.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1));
            jonas.EmployeeClothesList.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1));
            jonas.EmployeeClothesList.Add(new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1));
            EmployeeCollection.Add(jonas);

            Employee markus = new Employee(123, "Markus", "Öttken");
            markus.EmployeeClothesList.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2));
            markus.EmployeeClothesList.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 3));
            markus.EmployeeClothesList.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2));
            markus.EmployeeClothesList.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 2));
            markus.EmployeeClothesList.Add(new Clothes("Jacke", "Regenjacke", "L", "", 1));
            markus.EmployeeClothesList.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1));
            EmployeeCollection.Add(markus);

            Employee nadine = new Employee(456, "Nadine", "Molik");
            nadine.EmployeeClothesList.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Jacke", "Regenjacke", "L", "", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Jacke", "Fleecejacke", "S", "", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 1));
            nadine.EmployeeClothesList.Add(new Clothes("Kopfbedeckung", "Winterkappe", "", "Winter", 1));
            EmployeeCollection.Add(nadine);

            Employee daniel = new Employee(789, "Daniel", "Nickol");
            daniel.EmployeeClothesList.Add(new Clothes("Shirt", "Sommershirt", "XL", "Sommer", 2));
            daniel.EmployeeClothesList.Add(new Clothes("Shirt", "Wintershirt", "M", "Winter", 2));
            daniel.EmployeeClothesList.Add(new Clothes("Hose", "Sommerhose", "XL", "Sommer", 2));
            daniel.EmployeeClothesList.Add(new Clothes("Hose", "Winterhose", "L", "Winter", 2));
            daniel.EmployeeClothesList.Add(new Clothes("Jacke", "Regenjacke", "L", "", 2));
            daniel.EmployeeClothesList.Add(new Clothes("Jacke", "Winterjacke", "XL", "Winter", 2));
            daniel.EmployeeClothesList.Add(new Clothes("Kopfbedeckung", "Sommerkappe", "", "Sommer", 2));
            EmployeeCollection.Add(daniel);

        }
    }
}
