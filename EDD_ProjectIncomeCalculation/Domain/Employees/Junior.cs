namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public class Junior : Category
    {
        public override string Name => "Junior";

        public override double HourlyRate => 30;

        public override EmployeeRank Rank => EmployeeRank.Junior;
    }
}