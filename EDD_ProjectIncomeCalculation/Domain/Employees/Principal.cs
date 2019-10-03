namespace EDD_ProjectIncomeCalculation.Domain.Employees
{
    public class Principal : Category
    {
        public override string Name => "Principal";

        public override double HourlyRate => 50.0;

        public override EmployeeRank Rank => EmployeeRank.Principal;
    }
}