using System;

namespace Static_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student.change();
            Student student1 = new Student(12,"long");
            Student student2 = new Student(14,"buu");
            Student student3 = new Student(15,"duy");
            student1.Display();
            student2.Display();
            student3.Display();
        }
    }
    public class Student
    {
        private int rollno;
        private string Name;
        private static string college = "bhdss";
        public Student(int rollno, string Name)
        {
            this.rollno = rollno;
            this.Name = Name;
        }
        public static void change()
        {
            college = "codegym";
        }
        public void Display()
        {
            Console.WriteLine($"{rollno},{Name},{college}");
        }
    }
}
