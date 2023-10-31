using System.Collections.Generic;

namespace DVP.Models
{
    public class Employee
    {
        public int Id { get; }
        public string Firstname { get; }
        public string Lastname { get; }

        public Employee(int id, string firstname,string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
