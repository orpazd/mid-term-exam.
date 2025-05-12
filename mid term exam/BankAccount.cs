using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_term_exam
{
    internal class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public BankAccount(int accountNumber, Customer owner)
        {
            this.accountNumber = accountNumber;
            this.customerOwner = owner;
            this.balance = 0;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Deposit(double amount, string date)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} on {date}");
        }

        public virtual void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public virtual void PrintBalance()
        {
            Console.WriteLine($"Account {accountNumber} Balance: {balance}");
        }

        public int GetAccountNumber() => accountNumber;

    }
}
