using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp
{
	class Person
	{
		public string firstName, middleName, lastName;
		public Person(string firstName,string middleName,string lastName)
		{
			this.firstName = firstName;
			this.middleName = middleName;
			this.lastName = lastName;
		}

		public string GetFullName()

		{
			string fullName = firstName + " " + middleName + " " + lastName;
			return fullName;
		}

	}
}
