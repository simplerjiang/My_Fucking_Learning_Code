using System;

namespace 设置窗口
{
    public static class ObjectToStringExt
    {
        public static string ObjToStr<T>(this T obj)
        {
            string ret_str = string.Empty;
            System.Reflection.PropertyInfo[] props = obj.GetType().GetProperties(System.Reflection.BindingFlags.Public | GetInstance());
            foreach (System.Reflection.PropertyInfo p in props)
            {
                try
                {
                    string propName = p.Name;
                    object propValue = p.GetValue(obj);
                    string propValStr = "";
                    if (propValue != null)
                    {
                        propValStr = propValue.ToString();
                    }
                    ret_str += propName + ":" + propValStr + "\n";
                }
                catch
                {
                    continue;
                }
            }
            ret_str = "类型" + obj.GetType().Name + "的相关信息:\n" + ret_str;
            return ret_str;
        }

        private static System.Reflection.BindingFlags GetInstance()
        {
            return System.Reflection.BindingFlags.Instance;
        }
    }
    public class Customer
    {
        public string CompanyName { get; set; }
        public string Contact { get; set; }
    }
    public class Dress
    {
        public double Size { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.CompanyName = "模拟公司";
            c.Contact = "abcd@test.net";
            Console.WriteLine(c.ObjToStr());

            Console.Write("\n");
            Dress d = new Dress
            {
                Color = "Black",
                Size = 24.5d,
                Brand = "test"
            };
            Console.WriteLine(d.ObjToStr());
            Console.Read();
        }
    }
}
