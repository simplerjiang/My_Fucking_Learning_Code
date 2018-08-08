using System;
using System.Collections.Generic;
namespace LINQ语句
{
    public class Student
    {
        public uint ID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stus = new List<Student>();
            stus.Add(new Student { ID = 27001, Name = "小样", Score = 76 });
            stus.Add(new Student { ID = 27002, Name = "小样1", Score = 74 });
            stus.Add(new Student { ID = 27003, Name = "小样2", Score = 71 });
            stus.Add(new Student { ID = 27004, Name = "小样3", Score = 77 });
            var res = from s in stus orderby s.Score select s;
            Console.WriteLine("学生成绩升序");
            foreach (Student stu in res)
            {
                Console.WriteLine("{0}-{1}-{2}", stu.ID, stu.Name, stu.Score);
            }
            var res = from s in stus
                      orderby s.Score descending
                      select s;
            Console.WriteLine("学生成绩升序");
            foreach (Student stu in res)
            {
                Console.WriteLine("{0}-{1}-{2}", stu.ID, stu.Name, stu.Score);
            }
            Console.Read();
        }
    }
}
