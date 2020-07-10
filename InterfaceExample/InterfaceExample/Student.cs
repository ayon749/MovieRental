using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
	class Student: IGetInfo
	{
		public Student()
		{
		}

		public Student(string name, string regNo, string department)
		{
			Name = name;
			RegNo = regNo;
			Department = department;
		}

		public string Name { get; set; }
		public string RegNo { get; set; }
		public string Department { get; set; }

		public string GetInfo()
		{
			Console.WriteLine("Hi");
			return "abc";
		}

		public string GetInfo(int value)
		{
			throw new NotImplementedException();
		}
	}
}
