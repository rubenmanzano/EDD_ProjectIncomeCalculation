using EDD_ProjectIncomeCalculation.Domain.Base;

namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public class EmployeeBuilder : IFluentBuilder<Employee>
    {
        private string name;
        private string address;
        private int salary;

        public EmployeeBuilder CreateEmployee()
        {
            this.name = string.Empty;
            this.address = string.Empty;
            this.salary = 0;

            return this;
        }

        public EmployeeBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        public EmployeeBuilder WithAddress(string address)
        {
            this.address = address;
            return this;
        }

        public EmployeeBuilder WithSalary(int salary)
        {
            this.salary = salary;
            return this;
        }

        public Employee Build()
        {
            var emp = new Employee { Name = this.name, Address = this.address, Salary = this.salary };
            this.CreateEmployee();
            return emp;
        }
    }
}
