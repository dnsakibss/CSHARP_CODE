using System;

namespace polymorphism
{
    class Base
    {
        protected static int count = 0;
        protected readonly int id;

        public Base()
        {
            count++;
            id = count;
        }

        public virtual void Show()
        {
            Console.Write("Base-" + id + " ");
        }
    }

    class Derived : Base
    {
        private static int extra = 100;

        public override void Show()
        {
            Console.Write("Derived-" + (id + extra) + " ");
        }
    }

    class Advanced : Derived
    {
        private readonly int factor;

        public Advanced(int f)
        {
            factor = f;
        }

        public new void Show()
        {
            Console.Write("Advanced-" + (factor * id) + " ");
        }
    }

    internal class OutputTrace2
    {
        static void Main(string[] args)
        {
            Base[] arr = new Base[4];

            arr[0] = new Base();
            arr[1] = new Derived();
            arr[2] = new Advanced(2);
            arr[3] = new Advanced(3);

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }

            Console.WriteLine();

            Advanced a = new Advanced(5);
            a.Show();
        }
    }
}