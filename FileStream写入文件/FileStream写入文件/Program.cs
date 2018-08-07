using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream写入文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte[] buffer = new byte[10];
            rand.NextBytes(buffer);
            Console.WriteLine("随机产生的字节如下:\n{0}", BitConverter.ToString(buffer));
            Console.WriteLine("\n即将写入文件");
            try
            {
                FileStream fs = File.Create("data.dt");
                fs.Write(buffer, 0, buffer.Length);
                fs.Close();
                Console.WriteLine("写入成功");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //读出
            Array.Clear(buffer, 0, buffer.Length);  //清除字符串内容
            try
            {
                FileStream fs = File.OpenRead("data.dt");
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n从文件中读出的字节如下：\n{0}", BitConverter.ToString(buffer));
            Console.Read();
        }
    }
}
