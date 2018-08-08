using System;

namespace 反转数组
{
    public static void TestMethod(void);
    class Program
    {
        static void Main(string[] args)
        {
            byte[] arr = new byte[] { 5, 6, 7, 8 };
            Console.WriteLine("反转前数组的元素及次序");
            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("[{0}] - {1}", i, arr[i]);
            }
            Array.Reverse(arr);
            Console.WriteLine("\n 反转后");
            for (int n = 0;n<arr.Length;n++)
            {
                Console.WriteLine("[{0}] - {1}", n, arr[n]);
            }

            Console.Read();
        }
    }
}
