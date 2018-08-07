using System;

namespace ConsoleApp4
{
    public class Testclass
    {

        public Testclass(string name,string year)
        {
            Console.WriteLine("正在构造1，{0},{1}",name, year);
        }
        public Testclass (string name, int year)
        {
            Console.WriteLine("正在构造2，{0}，{1}", name, year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Testclass t1 = new Testclass("kong", "1997");
            Testclass t2 = new Testclass("Wong", 1997);
            Console.ReadKey();
        }
    }
}
