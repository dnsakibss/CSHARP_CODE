using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Jagged_ARRAY
    {
        static void Main(string[] args)
        {
            int[][] scores = new int[][]
            {
                new int[] { 90,80,70 },
                new int[] { 40,50,60 },
                new int[] { 100,90,80 }
            };
            Console.WriteLine("Jagged Array Row(s): ");
            int grandTotal = 0;
            for (int r = 0; r < scores.Length; r++)
            {
                int rowSum = 0;
                

                Console.Write($"Row {r}: ");
                for (int c = 0; c < scores[r].Length; c++)
                {
                    Console.Write(scores[r][c]+" ");
                    rowSum += scores[r][c];
                    grandTotal += scores[r][c];
                }
                Console.WriteLine($"| Total: {rowSum}");
               
                

                Console.WriteLine($"GRAND Total: {grandTotal}");
            }
            

        }
    }
}
