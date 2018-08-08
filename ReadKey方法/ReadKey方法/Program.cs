using System;

namespace ReadKey方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                Console.WriteLine("已按下了{0}键", keyInfo.Key);
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
