using System;

namespace ConsoleApp8
{
    public static class StringExt
    {
        public static string SplitBySpace(this string str)
        {
            char[] cs = str.ToCharArray();
            return string.Join(" ", cs);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefg";
            Console.WriteLine(StringExt.SplitBySpace(str));
            Console.Read();
        }
    }
}
