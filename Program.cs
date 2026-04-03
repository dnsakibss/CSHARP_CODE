using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    // 🔥 Example 1: Method Overloading
    class Calculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("int version");
            return a + b;
        }

        public double Add(double a, double b)
        {
            Console.WriteLine("double version");
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            Console.WriteLine("3 param version");
            return a + b + c;
        }
    }

    // 🔥 Example 2: Runtime Polymorphism (Overriding)
    class Payment
    {
        public virtual double Pay(double amount)
        {
            Console.WriteLine("Base Payment");
            return amount;
        }
    }

    class CreditCard : Payment
    {
        public override double Pay(double amount)
        {
            Console.WriteLine("Credit Card Payment");
            return amount + (amount * 0.02);
        }
    }

    class Bkash : Payment
    {
        public override double Pay(double amount)
        {
            Console.WriteLine("Bkash Payment");
            return amount + 15;
        }
    }

    class Cash : Payment
    {
        public override double Pay(double amount)
        {
            Console.WriteLine("Cash Payment");
            return amount;
        }
    }

    // 🔥 Example 3: Override vs New (Tricky)
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("A");
        }
    }

    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("B");
        }
    }

    class C : B
    {
        public new void Show()
        {
            Console.WriteLine("C");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // Example 1: Overloading
            // =========================
            Console.WriteLine("=== Overloading ===");
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(2, 3));
            Console.WriteLine(c.Add(2.5, 3.5));
            Console.WriteLine(c.Add(1, 2, 3));

            // =========================
            // Example 2: Overriding
            // =========================
            Console.WriteLine("\n=== Overriding ===");
            Payment[] payments = new Payment[3];

            payments[0] = new CreditCard();
            payments[1] = new Bkash();
            payments[2] = new Cash();

            foreach (Payment p in payments)
            {
                Console.WriteLine("Final Amount: " + p.Pay(1000));
            }

            // =========================
            // Example 3: Override vs New
            // =========================
            Console.WriteLine("\n=== Override vs New ==="); 

            A obj1 = new C();
            B obj2 = new C();
            C obj3 = new C();

            obj1.Show(); // B
            obj2.Show(); // B
            obj3.Show(); // C
        }
    }
}