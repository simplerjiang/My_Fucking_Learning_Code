using System;

namespace test5.c
{
    class Program
    {
        public struct Dress
        {
            public string Color;
            public double Size;
            public Dress(string color, double size)
            {
                Color = color;
                Size = size;
            }
        }

        static void F1(Dress d)
        {
            d.Color = "红色";
            d.Size = 17.213d;
        }

        static void F2(ref Dress d)
        {
            d.Color = "紫色";
            d.Size = 19.5d;
        }

        static void F3(out Dress d)
        {
            d = new Dress("浅灰", 18.37d);
        }

        static void Main(string[] args)
        {
            Dress d1 = new Dress("绿色", 19.2);
            Console.WriteLine("调用F1前:d1..Color:{0},Size:{1}", d1.Color, d1.Size);
            F1(d1);
            Console.WriteLine("调用F1后,Color:{0},Size:{1}", d1.Color, d1.Size);

            Dress d2 = new Dress("绿色", 8.5777d);
            Console.WriteLine("调用F2方法前：d2.Color:{0},Size:{1}", d2.Color, d2.Size);
            F2(ref d2);
            Console.WriteLine("调用F2方法后：d2.Color:{0},Size:{1}", d2.Color, d2.Size);

            Dress d3 = new Dress("红色", 22.2);
            Console.WriteLine("调用F3方法前：d3.Color:{0},Size:{1}", d3.Color, d3.Size);
            F3(out d3);
            Console.WriteLine("调用F3方法后：d2.Color:{0},Size:{1}", d3.Color, d3.Size);

            Console.Read();
        }
    }
}
