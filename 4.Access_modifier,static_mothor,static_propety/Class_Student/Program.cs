using System;

namespace Class_Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1,"long","hue",18);
            Console.WriteLine(student1.ToString());
            Student student2 = new Student();
            student2.SetId(2);
            student2.SetName("nguyen");
            student2.SetAddress("hanoi");
            student2.SetAge(18);
            Console.WriteLine(student2.ToString());
            Console.Read();
        }
    }
    public class Student
    {
        private int id;
        private string name;
        private string address;
        private int age;
        public Student()
        {

        }
        public Student(int id,string name,string address,int age)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.age = age;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetAddress()
        {
            return this.address;
        }
        public void SetAddress(string address)
        {
            this.address = address;
        }
        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public override string ToString()
        {
            return $"Id: {id} name: {name} address: {address} age: {age}";
        }
    }

}
