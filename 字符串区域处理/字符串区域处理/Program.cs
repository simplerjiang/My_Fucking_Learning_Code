using System;

namespace 字符串区域处理
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo en_cul, zh_cul;
            en_cul = System.Globalization.CultureInfo.GetCultureInfo("en");
            zh_cul = System.Globalization.CultureInfo.GetCultureInfo("zh");
            Console.WriteLine("----货币格式----");
            double dcur = 199.27;
            Console.WriteLine("用于{0}的货币格式: {1}", zh_cul.DisplayName, dcur.ToString("C2", zh_cul));
            Console.WriteLine("用于{0}的货币格式：{1}", en_cul.DisplayName, dcur.ToString("C2", en_cul));
            Console.WriteLine("\n-----数字格式-----");
            double dnv = 1234562.313;
            Console.WriteLine("用于{0}的数字格式:{1}", zh_cul.DisplayName, dnv.ToString("N", zh_cul));
            Console.WriteLine("用于{0}的数字格式：{1}", en_cul.DisplayName, dnv.ToString("N", en_cul));
            double dp = 0.45d;
            Console.WriteLine("用于{0}的百分数格式：{1}", zh_cul.DisplayName, dp.ToString("P0", zh_cul));
            Console.WriteLine("用于{0}的百分数格式：{1}", en_cul.DisplayName, dp.ToString("P0", en_cul));
            int nhex = 32602;
            Console.WriteLine("小写的十六进制字符串:{0}", nhex.ToString("x"));
            Console.WriteLine("大写的十六进制字符串:{0}", nhex.ToString("X"));
            Console.WriteLine("\n-----自定义数字格式-----");
            int num = 16;
            Console.WriteLine("摄氏度格式：{0}", num.ToString("#s 'Cs'"));
            
            Console.ReadKey();
        }
    }
}
