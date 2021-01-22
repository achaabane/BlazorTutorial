using EmployeeManagmentModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "jh@goo.fr",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department() { DepartmentId = 1, DepartmentName = "Marketing" },
                PhotoPath = "images/john.png"
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galawy",
                Email = "samGa@yahoo.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                Department = new Department() { DepartmentId = 2, DepartmentName = "IT" },
                PhotoPath = "images/sam.png"
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smiths",
                Email = "marys@goo.fr",
                DateOfBirth = new DateTime(1988, 1, 13),
                Gender = Gender.Male,
                Department = new Department() { DepartmentId = 3, DepartmentName = "Sales" },
                PhotoPath = "images/mary.png"
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Sarah",
                LastName = "Longway",
                Email = "longs@tu.fr",
                DateOfBirth = new DateTime(1999, 11, 4),
                Gender = Gender.Male,
                Department = new Department() { DepartmentId = 3, DepartmentName = "Sales" },
                PhotoPath = "images/jene.png"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
