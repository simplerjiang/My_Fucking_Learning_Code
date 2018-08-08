using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Sample
    {
        public static void CheckArray(int[] arr)
        {
            foreach (int n in arr)
            {
                if ((n % 2) != 0)
                {
                    throw new Exception("存在非偶数！");
                }
            }
        }
        public static double Area(double w, double h)
        {
            return w * h;
        }
    }
}
