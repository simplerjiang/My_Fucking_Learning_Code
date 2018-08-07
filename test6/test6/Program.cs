using System;

namespace test6
{
    class Program
    {
        public class Testclass
        {
            public string Name;
            public int Num;
        }
        static void Main(string[] args)
        {
            Testclass t = new Testclass();
            t.Name = "干";
            t.Num = 10;

            Console.WriteLine("我叫{0},一共{1}岁", t.Name, t.Num);

            Console.Read();
        }
    }
}
