using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Single_Array_1
    {
        static void Main(string[] args)
        {
            int[] marks = {90,98,92,96,94};

            int sum = 0;
            for(int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }

            double average = (double)sum / marks.Length;
            Console.WriteLine($"Total Marks: {sum}");
            Console.WriteLine($"Average Marks: {average}");
        }
    }
}
