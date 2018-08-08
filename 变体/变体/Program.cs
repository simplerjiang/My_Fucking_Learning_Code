using System;

namespace 变体
{
    public delegate void DoWork<T>(T arg);
    DoWork<A> del1 = delegate (A arg) { Console.WriteLine(arg.GetType().Name);};
    class Program
    {
        static void Main(string[] args)
        {
            Console.Read() ;
        }
    }
}
