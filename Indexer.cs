using System;
using System.Collections;

namespace polymorphism
{
    // ================== SIMPLE COLLECTION ==================
    // Demonstrates:
    // ✔ Indexer with int
    // ✔ Overloaded indexer with string
    public class SimpleCollection1
    {
        // Array storage → accessed using integer index
        private int[] items = new int[10];

        // Hashtable storage → accessed using string key
        private Hashtable map = new Hashtable();

        // 🔹 INDEXER (int)
        // Allows object to behave like array → sc[0]
        public int this[int index]
        {
            get { return items[index]; }   // return value at index
            set { items[index] = value; }  // assign value at index
        }

        // 🔹 OVERLOADED INDEXER (string)
        // Allows object to behave like dictionary → sc["key"]
        public int this[string key]
        {
            get
            {
                // Check if key exists
                if (map.ContainsKey(key))
                {
                    return (int)map[key]; // Hashtable returns object → casting needed
                }
                return -1; // default if key not found
            }
            set
            {
                map[key] = value; // store value using key
            }
        }
    }

    // ================== MATRIX (2D INDEXER) ==================
    // Demonstrates:
    // ✔ Multi-dimensional indexer
    public class Matrix1
    {
        private int[,] data;

        // Constructor defines size of matrix
        public Matrix1(int rows, int cols)
        {
            data = new int[rows, cols];
        }

        // 🔹 2D INDEXER → m[row, column]
        public int this[int r, int c]
        {
            get { return data[r, c]; }
            set { data[r, c] = value; }
        }
    }

    // ================== EXPRESSION-BODIED INDEXER ==================
    // Demonstrates:
    // ✔ Short syntax using =>
    public class ExprCollection1
    {
        private int[] arr = new int[5];

        // Same as normal indexer but shorter
        public int this[int i]
        {
            get => arr[i];       // return value
            set => arr[i] = value; // assign value
        }
    }

    class Indexer
    {
        static void Main(string[] args)
        {
            // ================== SIMPLE COLLECTION ==================
            SimpleCollection1 sc = new SimpleCollection1();

            sc[0] = 50;            // uses int indexer
            sc["score"] = 95;      // uses string indexer

            Console.WriteLine("sc[0] = " + sc[0]);
            Console.WriteLine("sc[\"score\"] = " + sc["score"]);

            // ================== MATRIX ==================
            Matrix1 m = new Matrix1(2, 3);

            m[0, 1] = 10; // row 0, column 1
            Console.WriteLine("m[0,1] = " + m[0, 1]);

            // ================== EXPRESSION INDEXER ==================
            ExprCollection1 ex = new ExprCollection1();

            ex[2] = 42;
            Console.WriteLine("ex[2] = " + ex[2]);

            Console.ReadKey();
        }
    }

    // ================== 🔥 INDEXER CONCEPT RECAP ==================
    //
    // 🔹 DEFINITION:
    // Indexer = allows an object to be accessed like an array
    // using [] instead of method calls
    //
    // 🔹 SYNTAX:
    // public TYPE this[parameter]
    // {
    //     get { }
    //     set { }
    // }
    //
    // 🔹 KEY IDEA:
    // Object behaves like:
    // - Array → obj[0]
    // - Dictionary → obj["key"]
    //
    // 🔹 FEATURES:
    // ✔ Can be overloaded (int, string, etc.)
    // ✔ Can be multi-dimensional (obj[x, y])
    // ✔ Uses get and set like properties
    //
    // 🔹 TYPES USED HERE:
    // 1. Integer indexer → sc[0]
    // 2. String indexer → sc["score"]
    // 3. 2D indexer → m[0,1]
    // 4. Expression-bodied → shorter syntax
    //
    // 🔹 DIFFERENCE: INDEXER vs PROPERTY
    // Property → uses name (obj.Value)
    // Indexer → uses [] (obj[0])
    //
    // 🔹 EXAM / MCQ POINTS:
    // ✔ Uses keyword 'this'
    // ✔ Cannot have name (only 'this')
    // ✔ Can be overloaded
    // ✔ Must have at least one parameter
    //
    // 🔹 REAL-LIFE ANALOGY:
    // Like accessing:
    // - Array → marks[0]
    // - Dictionary → student["name"]
    //
    // 🔹 QUICK RECAP:
    // - Indexer = array-like access
    // - Uses this[]
    // - Supports multiple forms
    //
    // =============================================================
}