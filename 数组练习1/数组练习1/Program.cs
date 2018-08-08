using System;

namespace 数组练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] arr1 = new char[][]
            {
                new char[] { 'a', 'a' },
                new char[] { 'a'}
            };
            for (int i=0; i<2;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr1[i][j]);
                }
            }
            Console.Read();
        }
    }
}
