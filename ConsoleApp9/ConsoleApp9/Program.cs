using System;

namespace ConsoleApp9
{
    class Program
    {
        static void TestMethod1()
        {
            Console.WriteLine("这是方法一");
        }
        static void TestMethod2()
        {
            Console.WriteLine("这是方法二");
        }
        public delegate void Mydelegate();

        static void Test(Mydelegate d)
        {
            if (d != null)
            {
                d();
            }
            d = TestMethod2;
        }

        static void Main(string[] args)
        {
            Mydelegate d;
            d = TestMethod1;
            Test(d);
            d();
            Console.ReadLine();
        }
    }
}
