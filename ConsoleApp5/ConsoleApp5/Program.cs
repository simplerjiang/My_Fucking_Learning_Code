using System;

namespace ConsoleApp5
{
    public class Person
    {
        public Person()
        {
            System.Diagnostics.Debug.WriteLine("Person,构造函数");
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void Ontest() { }

        public void MakeChange()
        {
            Console.WriteLine("this is MakeChange from Person()");
        }

        ~ Person()
        {
            System.Diagnostics.Debug.WriteLine("Person,析构函数");
        }
    }
    public class Student : Person
    {
        public Student()
        {
            System.Diagnostics.Debug.WriteLine("Student,构造函数");
        }
        public new void MakeChange()
        {
            Console.WriteLine("This is MakeChange() from Student");
        }

        public string Course { get; set; }
        ~Student()
        {
            System.Diagnostics.Debug.WriteLine("Person,析构函数");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.MakeChange();
            Console.Read();
        }
    }
}
