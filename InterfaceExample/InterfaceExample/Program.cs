using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student();
			string s = s1.GetInfo();
			Console.ReadKey();
		}
	}
}
