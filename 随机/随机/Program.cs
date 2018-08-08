using System;

namespace 随机
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            do
            {
                int num1 = rand.Next();
                int num2 = rand.Next();
                int result = num1 - num2;
                Console.WriteLine(result);
                System.Diagnostics.Debug.Assert(result > 0, "计算结果大于0");
            }
            while (Console.ReadKey(false).Key != ConsoleKey.Escape);
            Console.Read();
        }
    }
}
