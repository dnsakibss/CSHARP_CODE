using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Account
    {
        public int accountId;
        public string accountHolderName;
        public double balance;

        public Account(int AccountId, string AccountHolderName, double Balance)
        {
            this.accountId = AccountId;
            this.accountHolderName = AccountHolderName;
            this.balance = Balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Account ID: {accountId}");
            Console.WriteLine($"Account Name: {accountHolderName}");
            Console.WriteLine($"Account Name: {balance}");
        }
        public virtual void CalculateInterest()
        {

        }

    }

    class SavingsAccount : Account
    {
       // public double interest;
        public SavingsAccount(int AccountId, string AccountHolderName, double Balance) : base(AccountId, AccountHolderName, Balance)
        {
            this.accountId = AccountId;
            this.accountHolderName = AccountHolderName;
            this.balance = Balance;
           // this.interest = Interest;

        }
        public override void CalculateInterest()
        {
            base.CalculateInterest();
            if (balance > 100000)
            {
               double  interest = balance * 0.5;
                balance += interest;
                Console.WriteLine("Eligible for interest");
            }
            else
            {
                Console.WriteLine("Not Eligible Yet");
            }

        }
        class CurrentAccount : Account
        {
            //public double cainterest;
            public CurrentAccount(int AccountId, string AccountHolderName, double Balance) : base(AccountId, AccountHolderName, Balance)
            {
                this.accountId = AccountId;
                this.accountHolderName = AccountHolderName;
                this.balance = Balance;
              //  this.cainterest = Interest;

            }
            public override void CalculateInterest()
            {
                base.CalculateInterest();
                if (balance > 500000)
                {
                    double interest = balance * 0.2;
                    balance += interest;
                    Console.WriteLine("Eligible for interest");
                }
                else
                {
                    Console.WriteLine("Not Eligible Yet");
                }

            }
        }

        internal class Banking_system_CODE_writing
        {
            static void Main(string[] args)
            {
                Account[] accounts = new Account[4];
                accounts[0] = new SavingsAccount(1,"SAKIB",1000000);
                accounts[1] = new SavingsAccount(2,"BUSHRA",1100000);
                accounts[2] = new CurrentAccount(3,"Warisa",1200000);
                accounts[3] = new Account(4, "Asif", 130000);

                foreach(Account acc in accounts)
                {
                    acc.ShowInfo();
                    acc.CalculateInterest();
                    Console.WriteLine("_______________________________");
                }


            }
        }
    }
}
