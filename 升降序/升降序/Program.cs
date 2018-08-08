using System;
using System.Collections.Generic;
using System.Linq;

namespace 升降序
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stus = new List<Student>();
            stus.Add(new Student { Name = "小王", Age = 20, Date = new DateTime(2012, 9, 3) });
            stus.Add(new Student { Name = "小江", Age = 21, Date = new DateTime(2012, 9, 5) });
            stus.Add(new Student { Name = "小杨", Age = 21, Date = new DateTime(2013, 9, 3) });
            var res = stus.OrderBy(stu => stu.Date);
            Console.WriteLine("升序");
            foreach (Student i in res)
            {
                Console.WriteLine("{0}-{1}-{2}", i.Name, i.Age, i.Date);
            }
            Console.Read();
        }
    }
}
