using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_term_exam
{
    internal class CheckingAccount : BankAccount
    {
        public double overdraftLimit;

        public CheckingAccount(int accountNumber, Customer owner, double overdraftLimit)
            : base(accountNumber, owner)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (balance + overdraftLimit >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Withdrawal denied. Exceeds overdraft limit.");
            }
        }

        public override void PrintBalance()
        {
            Console.WriteLine($"Account {accountNumber} Balance: {balance}, Overdraft Limit: {overdraftLimit}");
        }
    }
}
