using System;

namespace 复制数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] srcArrm = new int[][]
            {
                new int[] {0,2,7 },
                new int[] {3,4,5}
            };
            int[][] disArrm = new int[2][];
            srcArrm.CopyTo(disArrm, 0);
            foreach (int[] x in disArrm)
            {
                foreach (int y in x)
                {
                    Console.Write(y + " ");
                }
                Console.Write('\n');
            }
            Console.Read();
        }
    }
}
