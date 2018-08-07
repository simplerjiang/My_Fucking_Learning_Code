using System;

namespace ConsoleApp12
{
    class Program
    {
        enum intEnum { V1, V2 }
        enum byteEnum : byte { V1, V2, V3 = 20 }
        enum sbyteEnum : sbyte { B1, B2 }
        enum shortNum : short { S1}
        enum ushortNum : ushort { Q1,Q2 }
        enum uintEum : uint { I1, I2 }
        enum longEum : long { L1, L2, L3 }
        enum ulongEum : ulong { L1, L2, L3 }

        static void Main(string[] args)
        {
            Console.WriteLine("int类型的:{0}", sizeof(intEnum));
            Console.WriteLine("byte类型的:{0}", sizeof(byteEnum));
            Console.WriteLine("sbyte类型的:{0}", sizeof(sbyteEnum));
            Console.WriteLine("ushortNum类型的:{0}", sizeof(shortNum));
            Console.WriteLine("ushortNum类型的:{0}", sizeof(ushortNum));
            Console.WriteLine("uint类型的:{0}", sizeof(uintEum));
            Console.WriteLine("long类型的:{0}", sizeof(longEum));
            Console.WriteLine("ulongEum类型的:{0}", sizeof(ulongEum));
            Console.ReadLine();
        }
    }
}
