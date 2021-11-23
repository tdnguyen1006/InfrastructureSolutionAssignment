using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureSolutionAssignment.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        public virtual Department Department { get; set; }


        public List<Employee> SampleEmployee()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = "1",                   // Simplify the id so I can put it in the salary tables.
                    Name = "Terence Burgess",
                    DepartmentId = "1",
                },
                new Employee
                {
                    Id = "2",
                    Name = "Esha Finney",
                    DepartmentId = "1",
                },
                new Employee
                {
                    Id = "3",
                    Name = "Xena Little",
                    DepartmentId = "1",
                },
                new Employee
                {
                    Id = "4",
                    Name = "Jorja Eaton",
                    DepartmentId = "2",
                },
                new Employee
                {
                    Id = "5",
                    Name = "Eesa Cooper",
                    DepartmentId = "2",
                },
                new Employee
                {
                    Id = "6",
                    Name = "Albi Buckley",
                    DepartmentId = "3",
                },
                new Employee
                {
                    Id = "7",
                    Name = "Kia Terry",
                    DepartmentId = "2",
                },
                new Employee
                {
                    Id = "8",
                    Name = "Onur Soto",
                    DepartmentId = "3",
                },
                new Employee
                {
                    Id = "9",
                    Name = "Fern Braun",
                    DepartmentId = "3",
                },
                new Employee
                {
                    Id = "10",
                    Name = "Hibba Underwood",
                    DepartmentId = "4",
                },
                new Employee
                {
                    Id = "11",
                    Name = "Joni Rahman",
                    DepartmentId = "5",
                },
                new Employee
                {
                    Id = "12",
                    Name = "Ivor Brady",
                    DepartmentId = "4",
                },
                new Employee
                {
                    Id = "13",
                    Name = "Miller Haynes",
                    DepartmentId = "5",
                },
                new Employee
                {
                    Id = "14",
                    Name = "Louisa Haines",
                    DepartmentId = "4",
                },
                new Employee
                {
                    Id = "15",
                    Name = "Ellena Campos",
                    DepartmentId = "5",
                },
                new Employee
                {
                    Id = "16",
                    Name = "Aadam Hull",
                    DepartmentId = "3",
                },
            };
            return employees;
        }
    }
}
