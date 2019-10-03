namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public class Employee
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Salary { get; set; }

        public Category Category { get; private set; }

        public void AssignCategory<T>() where T : Category, new()
        {
            Category =  new T();
        }
    }
}