using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism

{
    class Helpers 
    {
        public static void addBonus(ref int value,int bonus)
        {
                       value += bonus;
        }
        public static void GetMinMax(int[] data, out int min,out int max)
        {
            min = data[0];
            max = data[0];

            for(int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                    min = data[i];
                if (data[i] > max)
                    max = data[i];
            }

        }

        public static int SumAll(params int[] numbers)
        {
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;

        }
    }

    internal class ParamsModifiers
    {
        static void Main(string[] args)
        {
            int score = 100;
            Helpers.addBonus(ref score, 50);
            Console.WriteLine($"Bonus: {score}");

            int[] data = {5, 2, 9, 1, 5, 6};
            int min , max;
            Helpers.GetMinMax(data, out min, out max);
            Console.WriteLine($"Min: {min}, Max: {max}");

            int s1= Helpers.SumAll(1, 2, 3, 4, 5);
            int s2= Helpers.SumAll(10, 20, 30);
            Console.WriteLine($"Sum1: {s1}, Sum2: {s2}");
        }
    }
}
