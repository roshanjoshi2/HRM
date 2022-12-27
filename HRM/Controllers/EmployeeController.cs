using HRM.Enums;
using HRM.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details()
        {

            Employee e1 = new Employee();
            e1.Name = "Roshan";
            e1.Department = "Science";
            e1.Degisnation = "officer";
            e1.JoiningDate = new DateTime(2010, 02, 21);
            e1.Sex = Gender.Male;



            Employee e2 = new Employee();
            e2.Name = "Kapil";
            e2.Department = "Maths";
            e2.Degisnation = "Assistant";
            e2.JoiningDate = new DateTime(2016, 07, 21);
            e2.Sex = Gender.Male;


            Employee e3 = new Employee() { 
            Name = "Puja",
            Department = "health",
            Degisnation = "manager",
            JoiningDate = new DateTime(2000, 02, 21),
            Sex = Gender.Female};


            List<Employee> employees = new List<Employee>() { e1, e2, e3 };
            

            return View(employees);
        }
    }
}
