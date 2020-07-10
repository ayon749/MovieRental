using Spark.DAL;
using Spark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.BLL
{
	public class EmployeeManager
	{
		EmployeeGateway gateway = new EmployeeGateway();
		public List<Employee> GetAllEmployee()
		{
			return gateway.GetAllEmployees();
		}
		public bool SaveEmployee(Employee employee)
		{
			if (IsExist(employee))
			{
				return false;
			}
			return gateway.SaveEmployee(employee);
		}
		public bool IsExist(Employee employee)
		{
			var employeeList = gateway.GetAllEmployees();
			return employeeList.Any(emp => emp.NID == employee.NID);
		}
	}
}