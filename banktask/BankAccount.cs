using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banktask
{
    class BankAccount
    {
		private decimal _balance;

		public decimal balance
		{
			get { return _balance; }
			
		}
		private int _accountnumber;

		public int AccountNumber
		{
			get { return _accountnumber; }
		
		}
        public string OwnerName { get; }
        public BankAccount(int Accountnumber,string ownername,decimal Balance)
        {
			_accountnumber = Accountnumber;
			OwnerName = ownername;
			if(Balance>=0)
			_balance = Balance;
			
        }
		public void Deposit (decimal depositamount)
		{
			if(depositamount > 0)
			{
              _balance += depositamount;
                Console.WriteLine($"{depositamount} azn ugurla kocuruldu, cari balance{_balance}");
            }
			else
			{
                Console.WriteLine("deposit meblegi 0dan kicik ola bilmez");
			}
				
		}
		public void WithDraw (decimal withdrawamount)
		{
			if (withdrawamount < _balance && _balance>0 )
			{
				_balance -= withdrawamount;
                Console.WriteLine($"{ withdrawamount} azn balansdan cixarildi,cari balance{ _balance} ");
			}
			else if(withdrawamount<0)
				{
                Console.WriteLine("menfi ola bilmez");
			}
			else
			{
				Console.WriteLine("balansda kifayet qeder mebleg yoxdur");
			}
		}
		public void DisplayAccountInfo()
		{
            Console.WriteLine($"Owner Name: {OwnerName},Balance: {balance},Account number:{AccountNumber}");
		}
		public void TransferFunds(BankAccount recipient,decimal amount)
		{
			recipient.Deposit(amount);
            Console.WriteLine($"{recipient} shexsine {amount} azn qeder mebleg kocuruldu.");
		}
    }
}
