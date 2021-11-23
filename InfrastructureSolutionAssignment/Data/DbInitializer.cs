using InfrastructureSolutionAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureSolutionAssignment.Data
{
    public static class DbInitializer
    {
        public static async void Initialize(ApplicationDbContext context)
        {
            if(!context.Departments.Any())
            {
                List<Department> departments = new Department().SampleDepartments();
                context.Departments.AddRange(departments);
            }

            if(!context.Employees.Any())
            {
                List<Employee> employees = new Employee().SampleEmployee();
                context.Employees.AddRange(employees);
            }

            if (!context.EmployeeSalary.Any())
            {
                List<EmployeeSalary> salaries = new EmployeeSalary().SampleEmployeeSalary();
                context.EmployeeSalary.AddRange(salaries);
            }

            await context.SaveChangesAsync();
        }
    }
}
