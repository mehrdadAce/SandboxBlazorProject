using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxBlazorGit.Data
{
    interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }
}
