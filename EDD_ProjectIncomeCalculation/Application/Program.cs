using System;
using EDD_ProjectIncomeCalculation.Domain.Employees;
using EDD_ProjectIncomeCalculation.Domain.Projects;

namespace EDD_ProjectIncomeCalculation.Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new EmployeeBuilder();
            
            var foo = builder.WithName("foo").WithAddress("N/A").WithSalary(40000).Build();
            foo.AssignCategory<Professional>();

            var bar = builder.WithName("bar").WithAddress("N/A").WithSalary(21000).Build();
            bar.AssignCategory<Junior>();

            var baz = builder.WithName("baz").WithAddress("N/A").WithSalary(50000).Build();
            baz.AssignCategory<Principal>();


            var eddProject = new Project
            {
                Name = "EDD 2019",
                CustomerName = "ERNI",
            };

            eddProject.AllocateEmployee(foo, 400);
            eddProject.AllocateEmployee(bar, 400);
            eddProject.AllocateEmployee(baz, 100);

            Console.WriteLine($"The project { eddProject.Name } for the customer { eddProject.CustomerName }");
            Console.WriteLine($"has { eddProject.Employees.Count } people from ERNI involved");
            foreach (var employee in eddProject.Employees)
            {
                Console.WriteLine($"the category of { employee.Name } is { employee.Category.Name }");
            }
            Console.WriteLine(
                $"and the total project Income [ {eddProject.Income} ] - Salary expenses [ {eddProject.Expenses} ]  = Net Income [ {eddProject.Income - eddProject.Expenses }]");
        }
    }
}