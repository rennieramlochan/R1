using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using R1.Data;
using R1.Models;

namespace R1.Controllers
{
    public class EmployeeController : Controller
    {



        public IActionResult Index()
        {
            //Employee employee = new Employee
            //{
            //    EmployeeId = 1001,
            //    Name = "John Smith",
            //    Department = "Information Technology",
            //    MonthlySalary = 7500m,
            //    IsActive = true
            //};


    List<Employee> employees = new List<Employee>
    {
        new Employee
        {
            EmployeeId = 1001,
            Name = "John Smith",
            Department = "IT",
            MonthlySalary = 7500m,
            IsActive = true
        },
        new Employee
        {
            EmployeeId = 1002,
            Name = "Mary James",
            Department = "Human Resources",
            MonthlySalary = 8200m,
            IsActive = true
        },
        new Employee
        {
            EmployeeId = 1003,
            Name = "David Brown",
            Department = "Finance",
            MonthlySalary = 6800m,
            IsActive = false
        }
    };


            return View(employees);

        }



        public IActionResult TestViewBag()
        {
            ViewBag.PageTitle = "Employee Dashboard";
            ViewBag.Department = "Information Technology";
            ViewBag.TotalEmployees = 25;

            return View();
        }




















    }
}
