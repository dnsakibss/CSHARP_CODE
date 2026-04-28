using System;
using System.Collections;

namespace polymorphism
{
    class SimpleCollection
    {
        private int[] items = new int[10];
        private Hashtable table = new Hashtable();

        public int this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public int this[string key]
        {
            get { return (int)table[key]; }
            set { table[key] = value; }
        }
    }

    class Matrix
    {
        private int[,] data = new int[3, 3];

        public int this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }
    }

    class ExprCollection
    {
        private int[] arr = new int[10];

        public int this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }
    }

    internal class Final_LAB_TASK_2
    {
        static void Main(string[] args)
        {
            SimpleCollection sc = new SimpleCollection();
            sc[0] = 50;
            sc["score"] = 95;

            Console.WriteLine("sc[0] = " + sc[0]);
            Console.WriteLine("sc[\"score\"] = " + sc["score"]);

            Matrix m = new Matrix();
            m[0, 1] = 10;
            Console.WriteLine("m[0,1] = " + m[0, 1]);

            ExprCollection ex = new ExprCollection();
            ex[2] = 42;
            Console.WriteLine("ex[2] = " + ex[2]);
        }
    }
}