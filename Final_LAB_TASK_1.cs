using System;

namespace polymorphism
{
    interface IConnectable
    {
        void Connect(string target);
    }

    abstract class ElectronicDevice
    {
        public string Model;
        protected bool isOn;

        public ElectronicDevice(string model)
        {
            Model = model;
            isOn = false;
        }

        public void ShowStatus()
        {
            Console.WriteLine(Model + " | Power = " + isOn);
        }

        public abstract void Start();
    }

    class Laptop : ElectronicDevice, IConnectable
    {
        public Laptop(string model) : base(model) { }

        public override void Start()
        {
            isOn = true;
            Console.WriteLine("Laptop starting...");
        }

        public void Connect(string target)
        {
            Console.WriteLine("Laptop connected to " + target);
        }
    }

    class SmartPhone : ElectronicDevice, IConnectable
    {
        public SmartPhone(string model) : base(model) { }

        public override void Start()
        {
            isOn = true;
            Console.WriteLine("SmartPhone booting...");
        }

        public void Connect(string target)
        {
            Console.WriteLine("SmartPhone connected to " + target);
        }
    }

    internal class Final_LAB_TASK_1
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Laptop-2023");
            SmartPhone phone = new SmartPhone("Galaxy-S");

            laptop.Start();
            laptop.Connect("WiFi");
            laptop.ShowStatus();

            phone.Start();
            phone.Connect("Bluetooth");
            phone.ShowStatus();
        }
    }
}