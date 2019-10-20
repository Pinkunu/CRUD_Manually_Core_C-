using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_UI_Javascript.Models;

namespace MVC_UI_Javascript.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext employeeContext;

        public EmployeeController(EmployeeContext eC)
        {
            employeeContext = eC;
        }

        //Get Employee
        public ActionResult Index()
        {
            return View(employeeContext.Employees.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeContext.Employees.Add(employee);
                employeeContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        
        public ActionResult Edit(int id)
        {
            return View(employeeContext.Employees.Where(a => a.Employeeid == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            employeeContext.Employees.Update(employee);
            employeeContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
           return View(employeeContext.Employees.Where(a => a.Employeeid == id).FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            var emp = employeeContext.Employees.Where(a => a.Employeeid == id).FirstOrDefault();
            employeeContext.Employees.Remove(emp);
            employeeContext.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}

