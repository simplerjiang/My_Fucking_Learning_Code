using System;

namespace 类型强制转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string strToCvt = "ddd";
            try
            {
                int result = Convert.ToInt32(strToCvt);
                Console.WriteLine("将字符串{0}转换为int类型：{1}", strToCvt, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("转换失败!");
            }
            Console.ReadKey();
        }
    }
}
