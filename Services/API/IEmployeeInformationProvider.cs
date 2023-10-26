using DVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVP.Services.API
{
    public interface IEmployeeInformationProvider
    {
        List<Employee> EmployeesList { get; set; }
    }
}
