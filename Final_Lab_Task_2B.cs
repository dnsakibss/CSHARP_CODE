using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Final_Lab_Task_2B
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add("Hello");

            int value = (int)arr[0];
            Console.WriteLine("ArrayList value = " + value);

            List<int> list = new List<int>();
            list.Add(5);
            list.Add(2);
            list.Add(9);

            list.Sort();

            Console.WriteLine("Sorted List:");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("A", 80);
            dict.Add("B", 70);

            Console.WriteLine("Dictionary:");
            foreach (var pair in dict)
            {
                Console.WriteLine(pair.Key + " = " + pair.Value);
            }

            Console.WriteLine("\nObservation:");
            Console.WriteLine("ArrayList requires casting because it stores elements as object.");
            Console.WriteLine("List<int> does not allow mixed types because it is strongly typed.");
        }
    }
}