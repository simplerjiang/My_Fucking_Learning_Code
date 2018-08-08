using System;

namespace 数组练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[4];
            ints[0] = 1;
            ints[1] = 2;
            ints[2] = 3;
            ints[3] = 4;
            Console.WriteLine("For循环开始");
            for (int n = 0; n < ints.Length; n++)
            {
                Console.WriteLine(ints[n]);
            }

            Console.WriteLine("Foreach循环开始");

            foreach (int n in ints)
            {
                Console.WriteLine(n);
            }
            string[] strs = { "cat", "dog", "panda" };
            Console.WriteLine(string.Join(",", strs));
            strs[1] = "Big_dog";
            Console.WriteLine(string.Join(",", strs));

            Console.Read();
        }
    }
}
