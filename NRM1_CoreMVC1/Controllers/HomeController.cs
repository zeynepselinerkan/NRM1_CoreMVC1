using Microsoft.AspNetCore.Mvc;
using NRM1_CoreMVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NRM1_CoreMVC1.Controllers
{
    public class HomeController : Controller
    {

        List<Employee> List = new List<Employee>();

        public IActionResult Index()
        {
            Employee e = new Employee();
            e.FirstName = "Ali";
            e.LastName = "Veli";
            List.Add(e);

            Employee e1 = new Employee();
            e1.FirstName = "Osman";
            e1.LastName = "Veli";
            List.Add(e1);

            Employee e2 = new Employee();
            e2.FirstName = "yILMAZ";
            e2.LastName = "Veli";
            List.Add(e2);


            return View(List);
        }
    }
}
