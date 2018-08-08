using System;
using System.Globalization;
namespace 三种不同语言
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo zh_cul = CultureInfo.GetCultureInfo("zh");
            CultureInfo en_cul = CultureInfo.GetCultureInfo("en");
            CultureInfo ja_cul = CultureInfo.GetCultureInfo("ja");
            DateTime dt = new DateTime(2014, 8, 9, 17, 53, 40);
            string strFormat = ""; //格式
            strFormat = "D";
            Console.WriteLine("---------长日期--------");
            Console.WriteLine("{0,-8}{1}", zh_cul.DisplayName, dt.ToString(strFormat, zh_cul));
            Console.WriteLine("{0,-8}{1}", en_cul.DisplayName, dt.ToString(strFormat, en_cul));
            Console.WriteLine("{0,-8}{1}", ja_cul.DisplayName, dt.ToString(strFormat, ja_cul));
            strFormat = "d";
            Console.WriteLine("---------短日期--------");
            Console.WriteLine("{0,-8}{1}", zh_cul.DisplayName, dt.ToString(strFormat, zh_cul));
            Console.WriteLine("{0,-8}{1}", en_cul.DisplayName, dt.ToString(strFormat, en_cul));
            Console.WriteLine("{0,-8}{1}", ja_cul.DisplayName, dt.ToString(strFormat, ja_cul));
            strFormat = "F";
            Console.WriteLine("\n------完整格式-------");
            Console.WriteLine("{0,-8}{1}", zh_cul.DisplayName, dt.ToString(strFormat, zh_cul));
            Console.WriteLine("{0,-8}{1}", en_cul.DisplayName, dt.ToString(strFormat, en_cul));
            Console.WriteLine("{0,-8}{1}", ja_cul.DisplayName, dt.ToString(strFormat, ja_cul));
            strFormat = "dddd";
            Console.WriteLine("\n------周几-----------");
            Console.WriteLine("{0,-8}{1}", zh_cul.DisplayName, dt.ToString(strFormat, zh_cul));
            Console.WriteLine("{0,-8}{1}", en_cul.DisplayName, dt.ToString(strFormat, en_cul));
            Console.WriteLine("{0,-8}{1}", ja_cul.DisplayName, dt.ToString(strFormat, ja_cul));
            strFormat = "MMMM";
            Console.WriteLine("\n------月份-----------");
            Console.WriteLine("{0,-8}{1}", zh_cul.DisplayName, dt.ToString(strFormat, zh_cul));
            Console.WriteLine("{0,-8}{1}", en_cul.DisplayName, dt.ToString(strFormat, en_cul));
            Console.WriteLine("{0,-8}{1}", ja_cul.DisplayName, dt.ToString(strFormat, ja_cul));
            Console.Read();
        }
    }
}
