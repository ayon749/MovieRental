using Demo.DAL;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class EmployeesController : Controller
    {
		EmployeeGateway db = new EmployeeGateway();
		// GET: Employees
		public ActionResult Index()
        {
			
			List<Employee> employees = db.GetAllEmployee();
            return View(employees);
        }

		public ActionResult Save()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Save(Employee employee)
		{

			if (employee.EmployeeName != null && employee.Designation!=null && employee.email!=null)
			{
				bool isSaved = db.SaveEmployee(employee);
				if (isSaved)
				{
					return RedirectToAction("Index");
				}
				else
				{
					return View();
				}

			}
			return View();
		}
    }
}