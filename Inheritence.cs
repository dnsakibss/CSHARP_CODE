using System;

namespace polymorphism
{
    // Base Class
    class Employee
    {
        public string Name;
        public double BaseSalary;

        public Employee(string name, double salary)
        {
            Name = name;
            BaseSalary = salary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }

        public virtual void Display()
        {
            Console.WriteLine("Employee: " + Name);
        }
    }

    // Derived Class
    class Manager : Employee
    {
        public double Bonus;

        public Manager(string name, double salary, double bonus): base(name, salary)
        {
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Manager");
        }
    }

    // Multilevel Inheritance
    class SeniorManager : Manager
    {
        public double Stock;

        public SeniorManager(string name, double salary, double bonus, double stock): base(name, salary, bonus)
        {
            Stock = stock;
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() + Stock;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Role: Senior Manager");
        }
    }

    internal class Inheritence
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee("Rahim", 20000);
            employees[1] = new Manager("Karim", 30000, 5000);
            employees[2] = new SeniorManager("Sakib", 40000, 7000, 3000);

            foreach (Employee e in employees)
            {
                e.Display();
                Console.WriteLine("Salary: " + e.CalculateSalary());
                Console.WriteLine();
            }
        }
    }
}