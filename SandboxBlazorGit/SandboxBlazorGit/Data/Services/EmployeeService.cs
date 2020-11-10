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

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                var oldEmployee = GetEmployee(employee.Id);
                oldEmployee.Name = employee.Name;
                return true;
            }
            catch (Exception ex)
            {
                // LogError(ex.Message);
                return false;
            }
        }
    }
}
