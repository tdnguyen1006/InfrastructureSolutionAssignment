using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureSolutionAssignment.Models
{
    public class EmployeeSalary
    {
        public string Id { get; set; }
        public int Salary { get; set; }             // I use sqlite so int is the safest option.
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public List<EmployeeSalary> SampleEmployeeSalary()
        {
            List<EmployeeSalary> salaries = new List<EmployeeSalary>
            {
                new EmployeeSalary
                {
                    Id = "1",
                    EmployeeId = "1",
                    Salary = 40000,
                },
                new EmployeeSalary
                {
                    Id = "2",
                    EmployeeId = "2",
                    Salary = 35000,
                },
                new EmployeeSalary
                {
                    Id = "3",
                    EmployeeId = "3",
                    Salary = 42000,
                },
                new EmployeeSalary
                {
                    Id = "4",
                    EmployeeId = "4",
                    Salary = 50000,
                }
                ,new EmployeeSalary
                {
                    Id = "5",
                    EmployeeId = "5",
                    Salary = 30000,
                },
                new EmployeeSalary
                {
                    Id = "6",
                    EmployeeId = "6",
                    Salary = 56000,
                },
                new EmployeeSalary
                {
                    Id = "7",
                    EmployeeId = "7",
                    Salary = 100000,
                },
                new EmployeeSalary
                {
                    Id = "8",
                    EmployeeId = "8",
                    Salary = 77000,
                },
                new EmployeeSalary
                {
                    Id = "9",
                    EmployeeId = "9",
                    Salary = 400000,
                }
                ,
                new EmployeeSalary
                {
                    Id = "10",
                    EmployeeId = "10",
                    Salary = 60000,
                },
                new EmployeeSalary
                {
                    Id = "16",
                    EmployeeId = "16",
                    Salary = 55000,
                },
                new EmployeeSalary
                {
                    Id = "11",
                    EmployeeId = "11",
                    Salary = 57000,
                },
                new EmployeeSalary
                {
                    Id = "12",
                    EmployeeId = "12",
                    Salary = 65000,
                },
                new EmployeeSalary
                {
                    Id = "13",
                    EmployeeId = "13",
                    Salary = 80000,
                },
                new EmployeeSalary
                {
                    Id = "14",
                    EmployeeId = "14",
                    Salary = 61000,
                },
                new EmployeeSalary
                {
                    Id = "15",
                    EmployeeId = "15",
                    Salary = 40000,
                },
            };
            return salaries;
        }
    }
}
