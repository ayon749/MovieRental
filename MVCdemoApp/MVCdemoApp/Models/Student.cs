using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCdemoApp.Models
{
	public class Student
	{
		public Student(string name, string regNo, string departmentName)
		{
			Name = name;
			RegNo = regNo;
			DepartmentName = departmentName;
		}

		public string Name { set; get; }
		public string RegNo { set; get; }
		public string DepartmentName { set; get; }

	}
}