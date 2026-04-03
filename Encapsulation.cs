using System;

namespace polymorphism
{
    class BankAccount
    {
        private double balance;

        public string AccountName { get; set; }/////////////////
        /*
         private string accountName;

         public string AccountName
         {
             get { return accountName; }
             set { accountName = value; }
         }*/

        // Property with validation
        public double Balance
        {
            get 
            { 
            return balance;
            }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Invalid balance!");
            }
        }

        public BankAccount(string name, double initialBalance)
        {
            AccountName = name;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient balance!");
        }

        public void Show()
        {
            Console.WriteLine(AccountName + " Balance: " + balance);
        }
    }

    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("Sakib", 1000);
            acc.Show();

            acc.Deposit(500);
         //   acc.Withdraw(200);
            acc.Withdraw(2000); // invalid

            acc.Balance = -100; // blocked by encapsulation

            acc.Show();

            BankAccount acc1 = new BankAccount("Bushu", 1000);
            acc1.Show();
            acc1.Deposit(500);
            acc1.Withdraw(200);
           // acc1.Balance = -100;
            acc1.Show();
        }
    }
}