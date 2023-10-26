using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        private List<Clothes> EmployeeClothesList { get; set; }

        public Employee(int id, string firstname,string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            EmployeeClothesList = new List<Clothes>();
        }
    }
}
