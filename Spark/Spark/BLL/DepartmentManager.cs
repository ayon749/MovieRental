using Spark.DAL;
using Spark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.BLL
{
	public class DepartmentManager
	{
		DepartmentGateway gateway = new DepartmentGateway();

		public List<Department> GetDepartments()
		{
			return gateway.GetDepartments();
		}
	}
}