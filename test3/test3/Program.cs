using System;

namespace test3
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            Person ps1 = new Person { Name = "Time", Age = 22 };
            Person ps2 = ps1;

            Console.WriteLine("ps2.Name:{0},ps2.Age:{1}", ps2.Name, ps2.Age);
            ps1.Name = "new";
            ps1.Age = 23;
            Console.WriteLine("ps2.Name:{0},ps2.Age:{1}", ps2.Name, ps2.Age);
            Console.Read();
        }
    }
}
