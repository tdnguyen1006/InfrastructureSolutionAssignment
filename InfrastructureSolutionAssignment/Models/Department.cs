using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfrastructureSolutionAssignment.Models
{
    public class Department
    {
        public string Id { get; set; }
        public string DepartmentName { get; set; }

        public List<Department> SampleDepartments()
        {
            List<Department> departments = new List<Department>
            {
                new Department
                {
                    Id = "1",
                    DepartmentName = "IT"
                },
                new Department
                {
                    Id = "2",
                    DepartmentName = "HR"
                },
                new Department
                {
                    Id = "3",
                    DepartmentName = "Accounting"
                },
                new Department
                {
                    Id = "4",
                    DepartmentName = "Finance"
                },
                new Department
                {
                    Id = "5",
                    DepartmentName = "Customer Service"
                },
            };
            return departments;
        }
    }
}
