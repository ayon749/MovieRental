using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
	class Department: IGetInfo
	{
		public Department()
		{
		}

		public Department(string departmentName, string code)
		{
			DepartmentName = departmentName;
			Code = code;
		}

		public string DepartmentName { get; set; }
		public string Code { get; set; }

		public string GetInfo()
		{
			throw new NotImplementedException();
		}

		public string GetInfo(int value)
		{
			throw new NotImplementedException();
		}
	}
}
