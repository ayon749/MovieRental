using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
	class CheckingAccount : BankcAccount
	{
		public CheckingAccount()
		{
		}

		public CheckingAccount(double serviceCharge)
		{
			ServiceCharge = serviceCharge;
		}

		public CheckingAccount(string accountNo, string accountHolder) : base(accountNo, accountHolder)
		{
		}
		public double ServiceCharge { set; get; }

		public override void Transfer(string from, string to, double amount)
		{
			throw new NotImplementedException();
		}
	}
}
