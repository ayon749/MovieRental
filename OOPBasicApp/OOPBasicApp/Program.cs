using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person("Sakib","Al","Hasan");
			string fullName=person1.GetFullName();
			Console.WriteLine("My name is " + fullName);

			Console.ReadKey();

			
		}
	}
}
