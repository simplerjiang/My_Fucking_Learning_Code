using System;

namespace 数组查找元素
{
    class Program
    {
        private static bool FindProc(string obj)
        {
            if (obj.EndsWith("k"))
            {
                return true;
            }
            return false;
        }
        private static bool FindProc1(string obj)
        {
            if (obj.StartsWith("i"))
            {
                return true;
            }
            return false;
        }

        private static bool FindCallback(int val)
        {
            if (val <10)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3,3, 4, 5, 6, 7, 8, 9, 10 };
            int i;
            i = Array.IndexOf(arr, 3); //查找第一个匹配值的索引值
            Console.WriteLine("方法Array.IndexOf:{0}", i);
            i = Array.LastIndexOf(arr, 3); //查找最后一个匹配值的索引值
            Console.WriteLine("方法Array.LastIndexOf:{0}", i);

            string[] testArr = new string[]
            {
                /*0*/"ask",/*1*/"check",/*2*/"ask",/*3*/"food",/*4*/"ink" };

            int index1 = Array.FindIndex(testArr, new Predicate<string>(FindProc));
            Console.WriteLine("方法Array.FindIndex :{0}",index1);
            Predicate<string> DeleDosome = new Predicate<string>(FindProc);
            DeleDosome += new Predicate<string>(FindProc1);
            int index2 = Array.FindLastIndex(testArr, new Predicate<string>(DeleDosome));
            Console.WriteLine("方法Array.FindLastIndex :{0}", index2);

            arr = new int[] { 3, 6, 35, 10, 9, 13 };

            int result1 = Array.Find(arr, new Predicate<int>(FindCallback));
            Console.WriteLine("方法Array.Find() 返回值:{0}", result1);

            int result2 = Array.FindLast(arr, new Predicate<int>(FindCallback));
            Console.WriteLine("方法Array.FindLast() 返回值:{0}", result2);
            int[] result3 = Array.FindAll(arr, new Predicate<int>(FindCallback));
            Console.Write("方法Array.Findall()返回值：");
            foreach (int a in result3)
            {
                Console.Write(a + " ");
            }
            Console.Write('\n');

            Console.Read();
        }
    }
}
