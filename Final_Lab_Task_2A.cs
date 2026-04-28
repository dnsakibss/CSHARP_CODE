using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public T GetValue()
        {
            return value;
        }
    }
    public class Helper
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }
    }

    public interface IRepository<T>
    {
        void Add(T item);
        T Get();
    }

    public class IntRepository : IRepository<int>
    {
        private int data;

        public void Add(int item)
        {
            data = item;
        }

        public int Get()
        {
            return data;
        }
    }

    public delegate T Operation<T>(T a, T b);

    internal class Final_Lab_Task_2A
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
   
            Box<int> intBox = new Box<int>(10);
            Box<string> strBox = new Box<string>("Hello");

            Console.WriteLine("Box<int> = " + intBox.GetValue());
            Console.WriteLine("Box<string> = " + strBox.GetValue());

            int maxValue = Helper.Max(5, 9);
            Console.WriteLine("Max = " + maxValue);

            IntRepository repo = new IntRepository();
            repo.Add(100);
            Console.WriteLine("Repository value = " + repo.Get());

            Operation<int> op = Add;
            int result = op(3, 4);
            Console.WriteLine("Delegate result = " + result);
        }
    }
}