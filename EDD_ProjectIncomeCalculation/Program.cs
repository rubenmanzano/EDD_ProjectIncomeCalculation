using System;
using System.Collections.Generic;
using EDD_ProjectIncomeCalculation.Domain;

namespace EDD_ProjectIncomeCalculation
{
    public class Program
    {
        private const int HoursPerYear = 1800;
        private const int JuniorRate = 30;
        private const int ProfessionalRate = 35;
        private const int PrincipalRate = 50;
        private const int DevelopersHoursAllocation = 400;
        private const int PrincipalHoursAllocation = 100;

        public static void Main(string[] args)
        {
            var foo = new Employee
            {
                Name = "foo",
                Salary = 40000,
                HourPerYear = HoursPerYear,
                Category = new EmployeeCategory
                {
                    Name = "Professional",
                    Rank = EmployeeRank.Professional,
                    HourlyRate = ProfessionalRate
                }
            };

            var bar = new Employee
            {
                Name = "bar",
                Salary = 21000,
                HourPerYear = HoursPerYear,
                Category = new EmployeeCategory
                {
                    Name = "Junior",
                    Rank = EmployeeRank.Junior,
                    HourlyRate = JuniorRate
                }
            };

            var baz = new Employee
            {
                Name = "baz",
                Salary = 50000,
                HourPerYear = HoursPerYear,
                Category = new EmployeeCategory
                {
                    Name = "Principal",
                    Rank = EmployeeRank.Principal,
                    HourlyRate = PrincipalRate
                }
            };

            var eddProject = new Project
            {
                Name = "EDD 2019",
                CustomerName = "ERNI",
                Employees = new List<Employee>
                {
                    baz,
                    foo,
                    baz
                }
            };


            // Employee food and bar has 400h assigned to this project
            var fooExpenses = foo.Salary / (foo.HourPerYear / DevelopersHoursAllocation);
            var barExpenses = bar.Salary / (bar.HourPerYear / DevelopersHoursAllocation);

            // Employee baz has 100h assigned to this project
            var bazExpenses = baz.Salary / (baz.HourPerYear / PrincipalHoursAllocation);

            eddProject.Expenses = fooExpenses + barExpenses + bazExpenses;

            var fooIncome = foo.Category.HourlyRate * DevelopersHoursAllocation;
            var barIncome = bar.Category.HourlyRate * DevelopersHoursAllocation;
            var bazIncome = baz.Category.HourlyRate * PrincipalHoursAllocation;

            eddProject.Income = (long)(fooIncome + barIncome + bazIncome);

            var netIncome = eddProject.Income - eddProject.Expenses;

            Console.WriteLine(
                $"Project Income [ {eddProject.Income} ] - Salary expenses [ {eddProject.Expenses} ]  = Net Income [ {netIncome}]");
        }
    }
}