using InfrastructureSolutionAssignment.Data;
using InfrastructureSolutionAssignment.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureSolutionAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<EmployeeWithHighestSalaryDto>> GetTheEmployeeWithHighestSalaryInEachDepartment()
        {
            // sqlQuery = "select e.*, d.departmentName, Max(es.salary) from employees e 
            //            join departments d on e.departmentid = d.id
            //            join employeesalary es on e.id = es.employeeid
            //            group by d.id;"

            List<EmployeeWithHighestSalaryDto> dto = new List<EmployeeWithHighestSalaryDto>();
            var maxSalaries = (from e in _context.Employees
                                 join d in _context.Departments on e.DepartmentId equals d.Id
                                 join es in _context.EmployeeSalary on e.Id equals es.EmployeeId
                                 group new { e, d, es } by new { d.Id, d.DepartmentName } into newGroup
                                 select new { 
                                    DepartmentName = newGroup.Key.DepartmentName,
                                    DepartmentId = newGroup.Key.Id,
                                    Salary = newGroup.Max(x => x.es.Salary)
                                 });                                            // Get List of max salary in each department

            foreach (var salary in maxSalaries)
            {
                var employees = (from e in _context.Employees
                                 join d in _context.Departments on e.DepartmentId equals d.Id
                                 join es in _context.EmployeeSalary on e.Id equals es.EmployeeId
                                 where e.DepartmentId == salary.DepartmentId && es.Salary == salary.Salary
                                 select new EmployeeWithHighestSalaryDto 
                                 {
                                     DepartmentName = salary.DepartmentName,
                                     EmployeeId = e.Id,
                                     EmployeeName = e.Name,
                                     Salary = salary.Salary
                                 });                                            // Find list of employees that has specific salary in specific department

                dto.AddRange(employees);
            };
            return dto;
        }
    }
}
