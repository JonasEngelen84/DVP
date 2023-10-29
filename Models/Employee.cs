using System.Collections.Generic;

namespace DVP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public List<Clothes> EmployeeClothesList { get; set; }

        public Employee(int id, string firstname,string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            EmployeeClothesList = new List<Clothes>();
        }
    }
}
