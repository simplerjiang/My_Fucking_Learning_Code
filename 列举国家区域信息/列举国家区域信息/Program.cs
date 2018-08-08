using System;
using System.Globalization;

namespace 列举国家区域信息
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(950, 860);

            //基于区域性
            CultureInfo[] culs = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            Console.WriteLine("{0,-18}{1,-50}{2,-45}", "标记", "显示", "英文");
            Console.WriteLine("===========================================================================");
            foreach (CultureInfo c in culs)
            {
                Console.WriteLine("{0,-18}{1,-50}{2,-45}", c.Name, c.DisplayName, c.EnglishName);
            }

            //基于语言
            CultureInfo[] ntculs = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
            Console.WriteLine("{0,-18}{1, -50}{2, -45}", "标记", "显示", "英文");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (CultureInfo c in ntculs)
            {
                Console.WriteLine("  {1, -50}{2, -45}", c.Name, c.DisplayName, c.EnglishName);
            }
            Console.Read();
        }
    }
}
