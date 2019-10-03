using System.Collections.Generic;

namespace EDD_ProjectIncomeCalculation.Domain
{
    public class Project
    {
        public string Name { get; set; }

        public string CustomerName { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public long Expenses { get; set; }

        public long Income { get; set; }
    }
}