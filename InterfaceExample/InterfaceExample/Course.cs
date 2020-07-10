using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
	class Course:IGetInfo
	{
		public Course(string courseName, string cOurseCoude)
		{
			CourseName = courseName;
			COurseCoude = cOurseCoude;
		}

		public string CourseName { get; set; }
		public string COurseCoude { get; set; }

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
