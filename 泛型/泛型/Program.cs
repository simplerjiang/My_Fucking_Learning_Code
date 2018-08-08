using System;

namespace 泛型
{
    class Test<A>
    {
        public void Print(A a)
        {
            Console.WriteLine(a.GetType().FullName);
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Test<string> t1 = new Test<string>();
            t1.Print("abc");
            Console.Read();
        }
    }
}
