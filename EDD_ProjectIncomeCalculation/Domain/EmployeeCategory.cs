namespace EDD_ProjectIncomeCalculation.Domain
{
    public class EmployeeCategory
    {
        public string Name { get; set; }

        public double HourlyRate { get; set; }

        public EmployeeRank Rank { get; set; }
    }

    public enum EmployeeRank
    {
        Junior = 0,
        Professional = 1,
        Senior = 2,
        Principal = 3,
        SeniorPrincipal = 4,
        Director = 5
    }
}