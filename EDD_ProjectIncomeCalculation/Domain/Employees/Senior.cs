namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public class Senior : Category
    {
        public override string Name => "Senior";

        public override double HourlyRate => 40.0;

        public override EmployeeRank Rank => EmployeeRank.Senior;
    }
}