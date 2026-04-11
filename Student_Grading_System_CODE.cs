using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Student_
    {
        public int studentid;
        public string name;
        public string department;

        public Student_(int StudentId,string Name,string Department)
        {
            this.studentid = StudentId;
            this.name = Name;
            this.department = Department;

        }
        public void ShowInfo_()
        {
            Console.WriteLine($"Student ID: {studentid}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Department: {department}");
        }
        public virtual void CalculateGrade()
        {

        }

    }
    class Undergraduate : Student_
    {
        public int marks;
        public double attendence;
        public Undergraduate(int StudentId, string Name, string Department,int Marks,double Attendence) : base(StudentId, Name, Department)
        {
            this.studentid = StudentId;
            this.name = Name;
            this.department = Department;
            this.marks = Marks;
            this.attendence = Attendence;
        }
        public override void CalculateGrade()
        {
            base.CalculateGrade();
            if(marks > 80 && attendence>0.75)
            {
                Console.WriteLine($"Grade: A");
                Console.WriteLine("_______________________________");
            }
        }   

    }
    class Postgraduate : Student_
    {
        public int marks;
        public int researchScore;
        public Postgraduate(int StudentId, string Name, string Department,int Marks,int ResearchScore) : base(StudentId, Name, Department)
        {
            this.studentid = StudentId;
            this.name = Name;
            this.department = Department;
            this.marks = Marks;
            this.researchScore = ResearchScore;

        }
        public override void CalculateGrade()
        {
            base.CalculateGrade();
            if(marks > 75 && researchScore>80)
            {
                Console.WriteLine($"Grade: A");
                Console.WriteLine("_______________________________");
            }
        }   

    }
    internal class Student_Grading_System_CODE
    {
        static void Main(string[] args)
        {
            Student_[] st = new Student_[5];
            st[0] = new Undergraduate(23523192, "NAZMUS SAKIB SAMI", "CSE", 95, 1);
            st[1] = new Undergraduate(23543513, "KANIJ FATIMA BUSHRA", "CSE", 97, 1);
            st[2] = new Undergraduate(23526232, "KAZI WARISA TABASSUM", "CSE", 98, 0.8);
            st[3]= new Postgraduate(001, "ASIF", "AVIATION", 80, 90);
            st[4] = new Student_(002, "Abdul Huda", "Geography");
            
            foreach(Student_ sts in st)
            {
                sts.ShowInfo_();
                sts.CalculateGrade();
                Console.WriteLine("__________________________________");
            }
            //Student_ st1 = new Undergraduate(23523192, "NAZMUS SAKIB SAMI", "CSE", 95, 1);
            //Student_ st2= new Undergraduate(23543513, "KANIJ FATIMA BUSHRA", "CSE", 97, 1);
            //Student_ st3 = new Undergraduate(23526232, "KAZI WARISA TABASSUM", "CSE", 98, 0.8);
            //Student_ st4= new Postgraduate(001, "ASIF", "AVIATION", 80, 90);
            
            //st1.ShowInfo_();
            //st1.CalculateGrade();
            //st2.ShowInfo_();
            //st2.CalculateGrade();
            //st3.ShowInfo_();
            //st3.CalculateGrade();
            //st4.ShowInfo_();
            //st4.CalculateGrade();
            

        }
    }
}
