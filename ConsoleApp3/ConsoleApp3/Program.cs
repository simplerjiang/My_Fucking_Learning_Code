using System;

namespace ConsoleApp3
{
    class Program
    {
        public class Person
        {
            public string name { get; set; }
            public int age { get; set; }
        }


        static void TestMethod1(Person p)
        {
            p.name = "Loo";
            p.age = 33;
        }
        
        static void TestMethod2(Person p)
        {
            p = new Person() { name = "Chen", age = 29 };
        }

        static void TestMethod3(ref Person p)
        {
            p = new Person();
            p.name = "Lee";
            p.age = 12;
        }

        static void TestMethod4(out Person p)
        {
            p = new Person();
            p.name = "Huang";
            p.age = 27;
        }
        static void Main(string[] args)
        {
            Person ps = new Person { name = "jack", age = 23 };
            Console.WriteLine("调用前{0}，{1}", ps.name, ps.age);
            TestMethod1(ps);
            Console.WriteLine("调用后{0}，{1}", ps.name, ps.age);
            TestMethod2(ps);
            Console.WriteLine("调用后{0},{1}", ps.name, ps.age);
            TestMethod3(ref ps);
            Console.WriteLine("调用后{0},{1}", ps.name, ps.age);
            TestMethod4(out ps);
            Console.WriteLine("调用后{0},{1}", ps.name, ps.age);
            Console.Read();
        }
    }
}
