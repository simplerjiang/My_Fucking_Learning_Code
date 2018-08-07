using System;

namespace MyApp
{
    class Test1
    {
        static void Main(string[] args)
        {
            double data = default(double); // 初始化为0
            Console.WriteLine("变量：{0}", data);
            data = 126.35;
            Console.WriteLine("变量当前：{0}", data);
            data = 127777.2;
            Console.WriteLine("变量：{0}", data);
            Console.Read();
        }
    }
}