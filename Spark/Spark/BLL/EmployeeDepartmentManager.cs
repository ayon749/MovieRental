using Spark.DAL;
using Spark.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.BLL
{
	
	public class EmployeeDepartmentManager
	{
		EmployeeDepartmentGateway employeeDepartment = new EmployeeDepartmentGateway();
		public List<EmployeeWithDepartment> GetAllEmployeeWIthDepartment()
		{
			return employeeDepartment.GetAllEmployees();
		}

	}
}