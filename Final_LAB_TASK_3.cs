using System;

namespace polymorphism
{
    public delegate void Msg(string m);

    class Programm
    {
        public static void ShowA(string m)
        {
            Console.WriteLine("A: " + m);
        }

        public static void ShowB(string m)
        {
            Console.WriteLine("B: " + m);
        }
    }

    internal class Final_LAB_TASK_3
    {
        static void Main(string[] args)
        {
            Msg d = Programm.ShowA;
            d += Programm.ShowB;

            d("Hello");

            d -= Programm.ShowA;

            d("Hello");

            Msg anon = delegate (string x)
            {
                Console.WriteLine("Anon: " + x);
            };

            anon("Test");

            dynamic t = "World";
            Console.WriteLine(t.ToUpper());
        }
    }
}