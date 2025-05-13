using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_term_exam
{
    internal class BankBranch : IBankBranch
    {
        public int branchNumber;
        public string address;
        private CheckingAccount[] accounts;
        private int accountCount;

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
            accounts = new CheckingAccount[20];
            accountCount = 0;
        }

        public void AddAccount(BankAccount account)
        {
            if (accountCount < 20 && account is CheckingAccount)
            {
                accounts[accountCount] = (CheckingAccount)account;
                accountCount++;
            }
            else
            {
                Console.WriteLine("Cannot add account. Array full or wrong account type.");
            }
        }

        public void PrintAccounts()
        {
            Console.WriteLine($"Branch {branchNumber} Accounts:");
            for (int i = 0; i < accountCount; i++)
            {
                accounts[i].PrintBalance();
            }
        }
    }
}
