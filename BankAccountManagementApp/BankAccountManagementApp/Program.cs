using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
	class Program
	{
		static void Main(string[] args)
		{
			SavingAccount s1 = new SavingAccount();
			string message = s1.Deposit(10000);
			Console.WriteLine(message);
			Console.WriteLine("Balance" + s1.Balance);
			string m3 = s1.Withdraw(5000);
			Console.WriteLine(m3);
			Console.WriteLine("Balance" + s1.Balance);
			string m4 = s1.Withdraw(6000);
			Console.WriteLine(m4);
			Console.WriteLine("Balance" + s1.Balance);
			Console.WriteLine("");
			CheckingAccount c1 = new CheckingAccount();
			string m2 = c1.Deposit(50000);
			Console.WriteLine(m2);
			Console.WriteLine("Balance" + c1.Balance);
			m2 = c1.Withdraw(25000);
			Console.WriteLine(m2);
			Console.WriteLine("Balance" + c1.Balance);
			m2 = c1.Withdraw(25000);
			Console.WriteLine(m2);
			Console.WriteLine("Balance" + c1.Balance);
			m2 = c1.Withdraw(25000);
			Console.WriteLine(m2);
			Console.WriteLine("Balance" + c1.Balance);



			Console.ReadKey();
		}
	}
}
