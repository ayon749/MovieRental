using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
	abstract class BankcAccount
	{
		public BankcAccount()
		{
			Balance = 0;
		}

		public BankcAccount(string accountNo, string accountHolder):this()
		{
			AccountNo = accountNo;
			AccountHolder = accountHolder;
			
		}

		public string AccountNo { set; get; }
		public string AccountHolder { set; get; }
		public double Balance { private set; get; }
		

		public string Deposit(double Amount)
		{
			Balance += Amount;
			return "Deposit Successfull";
		}
		public virtual string  Withdraw(double Amount)
		{
			Balance -= Amount;
			return "Withdraw Successfyull";
		}
		public abstract void Transfer(string from, string to, double amount);
	}
}
