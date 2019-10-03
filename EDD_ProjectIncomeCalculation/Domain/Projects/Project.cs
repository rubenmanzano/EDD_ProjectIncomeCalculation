using System.Collections.Generic;
using EDD_ProjectIncomeCalculation.Domain.Employees;

namespace EDD_ProjectIncomeCalculation.Domain.Projects
{
    public class Project
    {
        public Project()
        {
            this.Employees = new List<Employee>();
        }

        public string Name { get; set; }

        public string CustomerName { get; set; }

        public ICollection<Employee> Employees { get; }

        public double Expenses { get; set; }

        public double Income { get; set; }

        public void AllocateEmployee(Employee employee, int hours)
        {
            this.Employees.Add(employee);
            this.Income += employee.Category.HourlyRate * hours;
            this.Expenses += (employee.Salary / employee.Category.HoursPerYear) * hours;
        }
    }
}
