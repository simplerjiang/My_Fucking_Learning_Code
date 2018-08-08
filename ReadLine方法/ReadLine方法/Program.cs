using System;

namespace ReadLine方法
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;
            do
            {
                line = Console.ReadLine();
                Console.WriteLine("读入一行字符:{0}", line);
            }
            while (line != null);
        }
    }
}
