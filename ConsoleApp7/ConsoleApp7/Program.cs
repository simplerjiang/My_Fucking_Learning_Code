using System;

namespace ConsoleApp7
{
    public interface ITest1
    {
        void Run();
    }
    public interface ITest2
    {
        void Run();
    }

    public class TestClass : ITest1, ITest2
    {
        void ITest1.Run()
        {
            Console.WriteLine("调用ITest1.Run()");
        }

        void ITest2.Run()
        {
            Console.WriteLine("调用ITest2.Run()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestClass t = new TestClass();

            ((ITest1)t).Run();
            ((ITest2)t).Run();

            Console.ReadKey();
        }
    }
}
