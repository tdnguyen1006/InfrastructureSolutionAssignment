using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureSolutionAssignment.DTOs
{
    public class EmployeeWithHighestSalaryDto
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public int Salary { get; set; }
    }
}
