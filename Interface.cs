using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    // INTERFACE 1
    // Defines a contract → any class implementing this MUST provide Print()
    public interface IPrintable
    {
        void Print(); // no body (by default public & abstract)
    }

    // INTERFACE 2 (INHERITING FROM ANOTHER INTERFACE)
    // ILoggable inherits IPrintable → so it has BOTH Print() and Log()
    public interface ILoggable : IPrintable // interface can inherit multiple interfaces
    {
        void Log(string message);
    }

    // INTERFACE 3
    public interface IStorable
    {
        bool Save();
    }

    // CLASS IMPLEMENTING MULTIPLE INTERFACES
    public class Report : ILoggable, IStorable
    {
        // Private field to store report content
        private string content;

        // Constructor to initialize content
        public Report(string text)
        {
            content = text;
        }

        // EXPLICIT INTERFACE IMPLEMENTATION
        // This method is ONLY accessible via IPrintable reference
        void IPrintable.Print()
        {
            Console.WriteLine("Printable report: " + content);
        }

        // EXPLICIT IMPLEMENTATION for ILoggable
        // Only accessible via ILoggable reference
        void ILoggable.Log(string message)
        {
            Console.WriteLine("Log: " + message + " (len=" + content.Length + ")");
        }

        // NORMAL IMPLEMENTATION (public)
        // Accessible directly using object
        public bool Save()
        {
            Console.WriteLine("Report saved: " + content);
            return true;
        }
    }

    internal class Interface
    {
        static void Main(string[] args)
        {
            // Creating object of Report
            Report r = new Report("Quarterly results");

            // TYPE CASTING to interface
            // Now r is treated as IPrintable
            IPrintable printable = (IPrintable)r;

            // Calls Print() via interface
            // (because of explicit implementation, cannot call directly with r.Print())
            printable.Print();

            // Casting to ILoggable
            ILoggable loggable = (ILoggable)r;

            // Calls Log() method
            loggable.Log("User opened document");

            // Casting to IStorable
            IStorable s = (IStorable)r;

            // Calls Save() (this one is public, so could also call r.Save())
            s.Save();

            Console.ReadKey();
        }
    }
}
// ================== C# INTERFACE - FULL RECAP ==================
//
// 🔹 DEFINITION:
// Interface = A contract that defines WHAT a class must do
// (but NOT HOW to do it)
//
// 🔹 KEY IDEA:
// - Interface → rules
// - Class → implementation of those rules
//
// 🔹 SYNTAX:
// interface IExample
// {
//     void Method();   // no body
// }
//
// class Demo : IExample
// {
//     public void Method()
//     {
//         // implementation
//     }
// }
//
// 🔹 INTERFACE RULES:
// - Cannot create object of interface
// - Methods are by default:
//     ✔ public
//     ✔ abstract (no body)
// - Cannot have constructors
// - Cannot have fields (only properties, methods, events)
//
// 🔹 IMPLEMENTATION RULES:
// - A class MUST implement ALL methods of interface
// - Use 'public' when implementing normally
//
// 🔹 MULTIPLE INHERITANCE:
// - A class can implement MULTIPLE interfaces ✔
//   Example: class A : I1, I2, I3
//
// 🔹 INTERFACE INHERITANCE:
// - An interface can inherit another interface ✔
//   Example: interface I2 : I1
//
// 🔹 EXPLICIT INTERFACE IMPLEMENTATION:
// - Used when you want to restrict access via interface only
//
// Example:
// void IExample.Method()
// {
//     // cannot call using object directly
// }
//
// Access:
// IExample obj = new Demo();
// obj.Method();  ✔
//
// Demo d = new Demo();
// d.Method();    ✘ (if explicit)
//
// 🔹 POLYMORPHISM:
// - Interface reference can hold object of implementing class
//   Example:
//   IExample e = new Demo();
//
// 🔹 REAL-LIFE ANALOGY:
// Interface = "Rules"
// Example:
// IPrintable → must print
// ILoggable → must log
// Class (Report) → follows all rules in its own way
//
// 🔹 EXAM / MCQ POINTS:
// ✔ Interface cannot be instantiated
// ✔ Supports multiple inheritance
// ✔ Methods are abstract by default
// ✔ No constructor allowed
// ✔ Class must implement all methods
//
// 🔹 COMMON QUESTIONS:
// Q: Why use interface?
// A: To achieve abstraction and multiple inheritance
//
// Q: Difference from abstract class?
// A:
// Interface → only rules
// Abstract class → rules + some implementation
//
// 🔹 QUICK RECAP:
// - Interface = contract
// - Class = implementation
// - Multiple interfaces allowed
// - Used for flexibility and loose coupling
//
// ===============================================================