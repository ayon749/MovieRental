using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountManagementApp
{
	class SavingAccount : BankcAccount
	{
		public SavingAccount()
		{
		}

		public SavingAccount(string accountNo, string accountHolder, double interestAmount):this(accountNo,accountHolder)
		{
			InterestAmount = interestAmount;
		}

		public SavingAccount(string accountNo, string accountHolder) : base(accountNo, accountHolder)
		{
		}

		public double InterestAmount { set; get; }

		public override string ToString()
		{
			return base.ToString();
		}

		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string Withdraw(double Amount)
		{
			if (Amount > Balance)
			{
				return "Insufficient Balance";
			}
			return base.Withdraw(Amount);
		}

		public override void Transfer(string from, string to, double amount)
		{
			throw new NotImplementedException();
		}
	}
}
