using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Single_Array_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers?: ");
            string input = Console.ReadLine();
            int n =int.Parse(input);

            int[] number = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Number {i + 1}: ");
                string numInput = Console.ReadLine();
                number[i] = int.Parse(numInput);
            }

            Console.WriteLine("You Entered: ");
                foreach(int value in number)
            {
                Console.WriteLine(value +" ");

            }
            Console.WriteLine();
        }

    }
}
