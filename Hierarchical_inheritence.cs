using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Person
    {
        public string Name
        {
            get; 
            private set;
        }
        public Person(string name)
        {
            Name = name;
        }   
        public void Display()
        {
            Console.WriteLine("Person: " + Name);
        }

    }
    class Student : Person
    {
        public string StudentID
        {
            get;
            private set;
        }
        public Student(string name, string studentID) : base(name)
        {
            StudentID = studentID;
        }
        public void ShwoStudent()
        {
            Console.WriteLine($"Student: {StudentID}, Name: {Name}");
        }
    }
    class Teacher : Person
    {
        public string Depratment
        {
            get;
            private set;
        }
        public Teacher(string name, string dept) : base(name)
        {
            Depratment = dept;
        }
        public void ShowTeacher()
        {
            Console.WriteLine($"Teacher: {Name}, Department: {Depratment}");
        }
    }
    internal class Hierarchical_inheritence
    {
        static void Main(string[] args)
        {
            Student student = new Student("SAKIB", "23523192");
            Teacher teacher = new Teacher("Bushra", "Computer Science");
            student.ShwoStudent();
            student.Display();
            teacher.ShowTeacher();
            teacher.Display();
        }
    }
}
