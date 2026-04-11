using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class jaggedArray_Practice
    {
        static void Main(string[] args)
        {
            int[][] array = new int[][]
            {
                new int[] {1,2,3 },
                new int[]{4,5,6},
                new int[]{7,8,9 }
            };
            int grandTotal = 0;
            for(int r = 0; r < array.Length; r++)
            {
                int rowSum = 0;
                Console.Write($"Row: {r}| ");
                for(int c = 0; c < array[r].Length; c++)
                {
                    Console.Write($"{array[r][c]} ");
                    rowSum += array[r][c];
                    grandTotal += array[r][c];
                }
                Console.WriteLine($"| Row Summation: {rowSum}");
            }
            Console.WriteLine($"Grand Total: {grandTotal}");
        }
    }
}
