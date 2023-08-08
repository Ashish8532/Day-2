using System;

namespace Exercise_2
{
    // Abstract class
    abstract class BankAccount
    {
        // Properties 
        public long AccountNumber; // The account number associated with the bank account.
        public double Balance;     // The current balance in the bank account.

        // Methods
        public abstract void Deposit(double amount); // Abstract method to deposit money into the account.
        public abstract void Withdraw(double amount); // Abstract method to withdraw money from the account.
    }

    // First Derived class
    class SavingsAccount : BankAccount
    {
        private double InterestRate; // The interest rate for the savings account.

        // Constructor to initialize the savings account.
        public SavingsAccount(long accountNumber, double balance, double interestRate)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            InterestRate = interestRate;
        }

        // Deposit method for savings account.
        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        // Withdraw method for savings account.
        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine($"Insufficient Balance. Your Main Balance is {Balance}");
            }
        }
    }

    // Second Derived class
    class CheckingAccount : BankAccount
    {
        private double OverdraftLimit; // The overdraft limit for the checking account.

        // Constructor to initialize the checking account.
        public CheckingAccount(long accountNumber, double balance, double overdraftLimit)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            OverdraftLimit = overdraftLimit;
        }

        // Deposit method for checking account.
        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        // Withdraw method for checking account.
        public override void Withdraw(double amount)
        {
            if (amount <= OverdraftLimit + Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Exceed the limit of withdrawn for existing balance and overdraft limit.");
            }
        }
    }

    // Driver Class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of SavingsAccount and CheckingAccount
            SavingsAccount savingsAccount = new SavingsAccount(34572637483, 1000.50, 0.4);
            CheckingAccount checkingAccount = new CheckingAccount(34572637483, 200, 400);

            // Performing operations on the savings account
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(750);
            Console.WriteLine($"SavingsAccount Balance is: {savingsAccount.Balance}");

            // Performing operations on the checking account
            checkingAccount.Deposit(1000);
            checkingAccount.Withdraw(3000);
            Console.WriteLine($"CheckingAccount Balance is: {checkingAccount.Balance}");
        }
    }
}
