namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public abstract class Category
    {
        public abstract string Name { get; }

        public abstract double HourlyRate { get; }

        public abstract EmployeeRank Rank { get; }

        // In the future this could change based on new category (for example: Director)
        public virtual int HoursPerYear => 1800;
    }
}
