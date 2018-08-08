using System;

namespace 获取键盘输入
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int input = 0;
            while ((input = Console.Read())!= -1)
            {
                if (input != 10 && input != 13)
                {
                    Console.WriteLine("输入了 {0} - {1}", (char)input, input);

                }
            }
        }
    }
}
