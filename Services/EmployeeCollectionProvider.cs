using DVP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Services
{
    public class EmployeeCollectionProvider
    {
        public static ObservableCollection<Employee> EmployeeCollection { get; }

        public void AddEmployeeToCollection(Employee employee)
        {
            EmployeeCollection.Add(employee);
        }
    }
}
