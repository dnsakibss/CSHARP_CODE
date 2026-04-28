using System;

namespace polymorphism   // ✅ changed namespace
{
    // ================== DELEGATE DECLARATION ==================
    // Delegate = type-safe function pointer
    // It can hold reference to methods with same signature
    public delegate void Notify1(string message);

    class Delegates
    {
        // ================== METHODS ==================

        // Method 1 → matches delegate signature (void, string)
        static void HandlerOne(string msg)
        {
            Console.WriteLine("HandlerOne: " + msg);
        }

        // Method 2 → also matches delegate signature
        static void HandlerTwo(string msg)
        {
            Console.WriteLine("HandlerTwo: " + msg);
        }

        // Method used for Func delegate (returns int)
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // ================== SINGLECAST DELEGATE ==================
            Notify1 n = new Notify1(HandlerOne); // assign method to delegate
            n("First call"); // calls HandlerOne

            // ================== MULTICAST DELEGATE ==================
            // += adds method to invocation list
            n += new Notify1(HandlerTwo);
            n("Multicast test"); // calls HandlerOne + HandlerTwo

            // -= removes method from invocation list
            n -= new Notify1(HandlerOne);
            n("After removal"); // only HandlerTwo executes

            // ================== ANONYMOUS METHOD ==================
            // Method without name using delegate keyword
            Notify1 anonymous = delegate (string m)
            {
                Console.WriteLine("Anonymous: " + m);
            };
            anonymous("Hello anon");

            // ================== ACTION DELEGATE ==================
            // Action → returns void (no return type)
            Action<string> a = delegate (string m)
            {
                Console.WriteLine("Action says: " + m);
            };
            a("Action call");

            // ================== FUNC DELEGATE ==================
            // Func → returns a value
            // Last type parameter = return type
            Func<int, int, int> f = new Func<int, int, int>(Add);
            Console.WriteLine("Func result = " + f(3, 4));

            Console.ReadKey();
        }
    }

    // ================== 🔥 DELEGATE CONCEPT RECAP ==================
    //
    // 🔹 DEFINITION:
    // Delegate = type-safe pointer to a method
    // Used to pass methods as parameters
    //
    // 🔹 TYPES USED:
    // 1. Singlecast Delegate → one method at a time
    // 2. Multicast Delegate → multiple methods (+= / -=)
    // 3. Anonymous Method → method without name
    // 4. Action → returns void
    // 5. Func → returns a value
    //
    // 🔹 MULTICAST RULE:
    // - Executes methods in sequence
    // - Last method result is returned (if return type exists)
    //
    // 🔹 SYNTAX TYPES:
    // Notify n = new Notify(Method);
    // Notify n = Method;
    //
    // 🔹 ACTION vs FUNC:
    // Action → no return type (void)
    // Func → returns value
    //
    // 🔹 REAL-LIFE ANALOGY:
    // Delegate = remote control
    // You press button → different methods execute
    //
    // 🔹 EXAM POINTS:
    // ✔ Delegates are type-safe
    // ✔ Support multiple methods
    // ✔ Used in event handling
    // ✔ Func returns value
    // ✔ Action returns void
    //
    // 🔹 QUICK RECAP:
    // - Delegate = method reference
    // - Multicast = multiple methods
    // - Action = void
    // - Func = return value
    //
    // ============================================================
}