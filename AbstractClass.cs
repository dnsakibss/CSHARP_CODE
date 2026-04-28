using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    // ABSTRACT CLASS (Blueprint)
    // Cannot create object of this class directly
    // Used to define common structure for all devices
    abstract class Device
    {
        // Property to store model name
        public string Model { get; }

        // Constructor → used to initialize model
        protected Device(string model)
        {
            Model = model;
        }

        // Abstract method → no body
        // Forces derived classes to provide implementation
        public abstract void Start();

        // Normal method → already implemented
        // Can be used directly by derived class objects
        public void Info()
        {
            Console.WriteLine("Device Model: " + Model);
        }
    }

    // DERIVED CLASS (Engine)
    // Inherits from Device
    class Engine : Device
    {
        // Calls base class constructor
        public Engine(string model) : base(model) { }

        // חובה: Must override abstract method
        // Provides specific behavior for Engine
        public override void Start()
        {
            Console.WriteLine("Engine starting..." + Model);
        }
    }

    // DERIVED CLASS (Printer)
    class Printer : Device
    {
        public Printer(string model) : base(model) { }

        // Different implementation of Start()
        public override void Start()
        {
            Console.WriteLine("Printer warming up... " + Model);
        }
    }

    internal class AbstractClass
    {
        static void Main(string[] args)
        {
            // POLYMORPHISM:
            // Reference type = Device (parent)
            // Object type = Engine (child)
            Device e = new Engine("ENG-100");

            // Reference type = Device
            // Object type = Printer
            Device p = new Printer("PRT-500");

            // Calls Info() from base class
            e.Info();   // Output: Device Model: ENG-100

            // Calls Start() from Engine class (runtime decision)
            e.Start();  // Output: Engine starting...ENG-100

            // Calls Info() again (same method for all)
            p.Info();   // Output: Device Model: PRT-500

            // Calls Start() from Printer class (runtime decision)
            p.Start();  // Output: Printer warming up... PRT-500
        }
    }
}
//can contain methods and properties
//instances cannot be created 
//when  a subclass created from abstract class has an abstract method

// ================== C# ABSTRACTION - FULL RECAP ==================
//
// 🔹 DEFINITION:
// Abstraction = Hiding implementation details and showing only essential features.
// Focus: "WHAT to do" (defined here) instead of "HOW to do" (defined in child class)
//
// 🔹 HOW TO ACHIEVE:
// - Abstract Class
// - Interface (more strict version of abstraction)
//
// 🔹 ABSTRACT CLASS RULES:
// - Cannot be instantiated (no object creation)
// - Can have:
//     ✔ Abstract methods (no body)
//     ✔ Non-abstract methods (with body)
//     ✔ Constructors
//     ✔ Fields / Properties
//
// 🔹 ABSTRACT METHOD RULES:
// - Declared without body
// - Must be overridden in derived class
// - Defined using 'abstract' keyword
//
// 🔹 DERIVED CLASS RULES:
// - Must implement all abstract methods
// - Uses 'override' keyword
//
// 🔹 KEY KEYWORDS:
// - abstract → used in base class
// - override → used in derived class
//
// 🔹 FLOW:
// Abstract class (blueprint)
//        ↓
// Abstract method (rule: must implement)
//        ↓
// Derived class (actual implementation)
//
// 🔹 REAL-LIFE ANALOGY:
// Device (abstract) = idea (like "Vehicle")
// Engine (derived) = real implementation (like "Car")
// Start() = common action, but different behavior per device
//
// 🔹 EXAM / MCQ POINTS:
// ✔ Abstract class CAN have constructor
// ✔ Abstract class CANNOT be instantiated
// ✔ Abstract method MUST be overridden
// ✔ Can have both abstract and normal methods
// ✘ Abstract methods cannot have a body
//
// 🔹 COMMON QUESTIONS:
// Q: Why use abstraction?
// A: To reduce complexity and enforce structure
//
// Q: What happens if child class does not override?
// A: Compile-time error
//
// Q: Can abstract class have object?
// A: No
//
// 🔹 QUICK RECAP:
// - Abstract class = blueprint
// - Abstract method = rule
// - Derived class = implementation
//
// ===============================================================