namespace EDD_ProjectIncomeCalculation.Domain
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public int Salary { get; set; }

        public EmployeeCategory Category { get; set; }

        public int HourPerYear { get; set; }
    }
}