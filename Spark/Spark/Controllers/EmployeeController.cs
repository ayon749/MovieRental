using Spark.BLL;
using Spark.Models;
using Spark.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spark.Controllers
{
    public class EmployeeController : Controller
    {
		EmployeeManager employeeManager = new EmployeeManager();
		DepartmentManager departmentManager = new DepartmentManager();
		EmployeeDepartmentManager employeeDepartment = new EmployeeDepartmentManager();

		// GET: Employee
		public ActionResult Index()
        {
			List<EmployeeWithDepartment> employees = employeeDepartment.GetAllEmployeeWIthDepartment();
            return View(employees);
        }

		public ActionResult Save()
		{
			var departments = departmentManager.GetDepartments();
			ViewBag.Departments = departments;
			ViewBag.saveFailed = false;
			return View();
		}
		[HttpPost]
		public ActionResult Save(Employee employee)
		{
			var isSaved=employeeManager.SaveEmployee(employee);
			if (isSaved)
			{
				ViewBag.saveFailed = false;
				return RedirectToAction("Index");

			}
			var departments = departmentManager.GetDepartments();
			ViewBag.Departments = departments;
			ViewBag.saveFailed = true;
			return View();
		}
	}
}