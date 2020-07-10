using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spark.ViewModel
{
	public class EmployeeWithDepartment
	{
		public int EmployeeId { get; set; }
		public string EmployeeName { get; set; }
		public string Designation { get; set; }
		public string NID { get; set; }
		public DateTime JoiningDate { get; set; }
		public string BloodGroup { get; set; }
		public int DepartmentId { get; set; }
		public string Code { get; set; }
		public string DepartmentName { get; set; }
	}
}
