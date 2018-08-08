using System;

namespace 输出文本信息
{
    public class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public DateTime ProductDate { get; set; }
        public override string ToString()
        {

            return "编号: " + No.ToString() + ", 产品名称: " + Name + "日期: " + ProductDate.ToShortDateString() ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product()
            {
                No = 101,
                Name = "洗衣机",
                ProductDate = new DateTime(2012, 3, 15)
            };
            Console.WriteLine(p);
            Console.Read();
        }
    }
}
