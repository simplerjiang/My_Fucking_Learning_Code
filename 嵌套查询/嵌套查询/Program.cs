using System;

namespace 嵌套查询
{
    public class Goods
    {
        public string GsNo { get; set; }
        public string GsName { get; set; }
        public double GetPrice { get; set; }
    }

    public class SalesOrder
    {
        public int OrderID { get; set; }
        public string GoodsNo { get; set; }
        public DateTime Time { get; set; }
        public int Qty { get; set; }
    }
    Goods[] goodsArr =
    {
        new Goods
        {
            new Goods {GsNo = "G-1",GsName="报纸}
        };
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
