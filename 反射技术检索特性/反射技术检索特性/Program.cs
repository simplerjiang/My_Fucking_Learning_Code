using System;

namespace 反射技术检索特性
{
    class Program
    {
        [AttributeUsage(AttributeTargets.All)]
        public class TypeInfoAttribute : Attribute
        {
            public string Description { get; set; }
        }
        [TypeInfo(Description = "枚举类型")]
        enum TestEnum { One = 1, Two, Three }

        [TypeInfo(Description = "类")]
        public class Goods { }
        
        static void Main(string[] args)
        {
            object[] attrs = typeof(TestEnum).GetCustomAttributes(typeof(TypeInfoAttribute), false);
            if (attrs.Length > 0)
            {
                TypeInfoAttribute ti = (TypeInfoAttribute)attrs[0];
                Console.WriteLine("TestEnum信息为:{0}", ti.Description);
            }
            attrs = typeof(Goods).GetCustomAttributes(typeof(TypeInfoAttribute), false);
            if (attrs.Length > 0)
            {
                TypeInfoAttribute ti = (TypeInfoAttribute)attrs[0];
                Console.WriteLine("Goods信息为:{0}", ti.Description);
            }
            Console.Read();
        }
    }
}
