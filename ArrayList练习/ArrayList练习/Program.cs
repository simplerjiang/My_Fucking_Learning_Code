using System;
using System.Collections;
namespace ArrayList练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(20.977d);
            list.Add("hello");
            list.Add(980000000L);

            Console.WriteLine("{0} - {0}", (int)list[0]);
            Console.WriteLine("{0} - {0}", (long)list[3]);
            Console.WriteLine("元素个数: {0}", list.Count);
            list.RemoveAt(list.Count - 1);
            Console.WriteLine("元素个数: {0}", list.Count);
            list.Remove("hello");
            Console.WriteLine("元素个数: {0}", list.Count);
            Console.Read();
        }
    }
}
