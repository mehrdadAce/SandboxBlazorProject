using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxBlazorGit.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Mehrdad Kazemi"
            },
            new Employee
            {
                Id = Guid.NewGuid(),
                Name = "Tina Desmet"
            }
        };
        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
