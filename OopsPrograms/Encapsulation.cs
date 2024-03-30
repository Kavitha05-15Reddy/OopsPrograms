using System;
using System.Security.Permissions;

namespace OopsPrograms
{
    class BankAccount
    {
        protected double balance;
        public BankAccount()
        {
            balance = 0;
        }
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0) 
            {
                Console.WriteLine("Deposit amount must be positive");
                return;
            }
            balance += amount;
            Console.WriteLine($"Successfully deposited : {amount} Current balance : {balance}");
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be positive");
                return;
            }
            if (amount > balance) 
            {
                Console.WriteLine("Insufficient funds");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Successfully withdrawn : {amount} Current balance : {balance}");
        }
        public double GetBalance()
        {
            Console.WriteLine("Available Balanace:"+ balance);
            return balance;
        }
        public virtual double CalculateInterest()
        {
            return 0;
        }
    }
    class SavingsAccount : BankAccount 
    {
        public SavingsAccount(double initialBalance) :base(initialBalance)
        {
        }
        public override double CalculateInterest()
        {
            double interestrate = 0.05;
            return balance * interestrate;
        }
    }
    class CurrentAccount : BankAccount
    {
        public CurrentAccount(double initialBalance) : base(initialBalance)
        {
        }
        public override double CalculateInterest()
        {
            return 0;
        }
    }
}
