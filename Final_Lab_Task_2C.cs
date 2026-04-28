using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    
    public delegate void Notify(string message);

    public class MyEventArgs : EventArgs
    {
        public int Value { get; set; }

        public MyEventArgs(int value)
        {
            Value = value;
        }
    }

    public class Publisher
    {
        public event EventHandler<MyEventArgs> OnNotify;

        public void TriggerEvent(int val)
        {
            OnNotify?.Invoke(this, new MyEventArgs(val));
        }
    }

    internal class Final_Lab_Task_2C
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("A: " + message);
        }

        public static void MethodB(string message)
        {
            Console.WriteLine("B: " + message);
        }

        static void Main(string[] args)
        {
            Notify notify = MethodA;
            notify += MethodB;

            notify("Hello");

            int x = 5;

            Notify anon = delegate (string msg)
            {
                Console.WriteLine("Anonymous value = " + x);
            };

            x = 10; 
            anon("Test");

            Publisher pub = new Publisher();

            pub.OnNotify += (sender, e) =>
            {
                Console.WriteLine("Event received value = " + e.Value);
            };

            pub.TriggerEvent(50);
        }
    }
}