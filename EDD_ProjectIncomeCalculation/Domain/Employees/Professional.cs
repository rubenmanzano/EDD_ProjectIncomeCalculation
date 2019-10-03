namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public class Professional : Category
    {
        public override string Name => "Professional";

        public override double HourlyRate => 35.0;

        public override EmployeeRank Rank => EmployeeRank.Professional;
    }
}