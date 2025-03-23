using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace banktask
{
    class Bank
    {
        public BankAccount[] bankAccounts;
        public Bank()
        {
            bankAccounts = new BankAccount[0];
        }

        public void Add(BankAccount bankaccount)
        {
            Array.Resize(ref bankAccounts, bankAccounts.Length + 1);
            bankAccounts[bankAccounts.Length - 1] = bankaccount;

        }
        public BankAccount GetBankAccountByOwner(string OwnerName)
        {
            BankAccount bankAccount = null;
            for (int i = 0; i < bankAccounts.Length; i++)
            {
             if (bankAccounts[i].OwnerName == OwnerName)
                {
                    bankAccount = bankAccounts[i];
                    break;
                }
             else
                {
                    Console.WriteLine("bele bir account yoxdu");
                }
            }
            return bankAccount;

        }
        public void GetBankAccountsCount()
        {
            Console.WriteLine(bankAccounts.Length);
        }
        public void DeleteBankAccount(string OwnerName)
        {
            BankAccount bankAccount = null;
            for(int i = 0; i < bankAccounts.Length; i++)
            {
                if (bankAccounts[i].OwnerName == OwnerName)
                {
                    bankAccounts[i] = bankAccount;
                    Array.Resize(ref bankAccounts, bankAccounts.Length - 1);
                    bankAccounts[bankAccounts.Length - 1] = bankAccount;
                }
            }
        }
    }
}
