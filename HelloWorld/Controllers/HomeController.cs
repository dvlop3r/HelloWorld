using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorld.controller
{
    public class HomeController : Controller
    {
        private readonly EmployeeDB db;
        public HomeController(EmployeeDB db)
        {
            this.db = db;
        }

        public IActionResult Index(int page)
        {
            double recordCount = db.Employees.Count();
            double pageCount = Math.Ceiling(recordCount / 10);
            ViewBag.pageCount = pageCount;
            Employees[] employees = db.Employees.Skip(page * 10).Take(10).OrderByDescending(x => x.id).ToArray();
            ViewData["title"] = "Index action";
            if (Request.Headers["AjaxRequest"] == "XMLHttpRequest")
                return PartialView(employees);
            return View(employees);
        }
        //[Route("home{year:min(2000)}/{month:range(0,8)}/{key=sarwan}")]
        
        [Authorize,HttpGet,Route("create")]
        public IActionResult Create()
        {
            ViewData["title"]= "Create action";
            return View();
        }
        //[HttpPost]
        //Alternate way to default Create action with HttpPost
        [Authorize,Route("FormProcessor")]
        public IActionResult FormProcessor(Employees emp)
        {
            ViewData["title"] = "Create action";
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                ViewData["message"] = "Employee added successfully!";
            }
            else
                ViewData["message"] = "Employee creation failure!";
            return View("create",emp);
        }
        [Route("employee/{name?}")]
        public IActionResult TestAction(string name)
        {
            string[] route = Request.Path.Value.Split("/");
            return new ContentResult { Content = string.Format("employee name: {0}", Request.Path.Value + name) };
        }
        [Authorize,Route("edit")]
        public IActionResult Edit(int id)
        {
            ViewData["title"] = "Edit action";
            Employees employees = db.Employees.Find(id);
            if (employees == null) 
                return new ContentResult { Content = "" };
            return View(employees);
        }
        [Authorize,Route("EditProcessor")]
        [HttpPost]
        public IActionResult EditProcessor(Employees employee)
        {
            ViewData["title"] = "Edit action";
            if (!ModelState.IsValid)
            {
                ViewData["message"] = "Employee update failure!";
                return View("edit", employee);
            }
            Employees existing_emp = db.Employees.Find(employee.id);
            existing_emp.Name = employee.Name;
            existing_emp.Position = employee.Position;
            existing_emp.Department = employee.Department;
            existing_emp.Grade = employee.Grade;
            existing_emp.Gender = employee.Gender;
            db.SaveChanges();
            ViewData["message"] = "Employee updated successfully!";
            return View("edit", existing_emp);
        }
        [Authorize]
        public IActionResult Detail(int id)
        {
            Employees[] employees = db.Employees.Where(x => x.id == id).ToArray();
            if (employees.Length == 0) 
                return new ContentResult {Content="" };
            return View(employees.First());
        }
        [Authorize]
        public IActionResult Delete(int id,Employees[] emp)
        {
            Employees[] employees = db.Employees.Where(x => x.id == id).ToArray();
            if (employees.Length == 0)
                return new ContentResult { Content = "" };
            db.Employees.Remove(employees.First());
            db.SaveChanges();
            ViewData["message"] = "Employee deleted successfully!";
            employees = db.Employees.OrderByDescending(x => x.id).ToArray();
            return View("index", employees);
        }
    }
}
