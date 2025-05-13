using mid_term_exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_term_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer("123456789", "Idan", "050-1234567");
            CheckingAccount acc1 = new CheckingAccount(1993, cust1, 1500);

            acc1.Deposit(500);
            acc1.Deposit(1250, "2025-05-13");
            acc1.Withdraw(1000);

            BankBranch branch = new BankBranch(1, "Netanya");
            branch.AddAccount(acc1);

            branch.PrintAccounts();

        }
    }
}
