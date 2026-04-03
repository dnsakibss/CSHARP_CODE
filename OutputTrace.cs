using System;

namespace polymorphism
{
    class Counter
    {
        private int count = 0;

        public int Value
        {
            get { return count; }
            set
            {
                if (value % 2 == 0)
                    count = value;
                else
                    count += 1;
            }
        }

        public void Increment()
        {
            count++;
        }

        public void Show()
        {
            Console.Write(count + " ");
        }
    }

    internal class OutputTrace
    {
        static void Main()
        {
            Counter c = new Counter();

            for (int i = 1; i <= 5; i++)
            {
                c.Value = i;
                c.Increment();
                c.Show();
            }
        }
    }
}