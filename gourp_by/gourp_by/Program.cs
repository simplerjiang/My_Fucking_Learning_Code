using System;
using System.Collections.Generic;
using System.Linq;

namespace dd
{
    public class Category
    {
        public int catID { get; set; }
        public string catName { get; set; }
    }

    public class BookInfo
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int CateID { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> Categorys = new List<Category>
            {
                new Category{catID = 201, catName="文学类"},
                new Category{catID = 202, catName="xxx"},
                new Category{catID = 203, catName="dddd"}
            };
            List<BookInfo> books = new List<BookInfo>
            {
                new BookInfo {BookID = 1,BookName="书1",CateID=202},
                new BookInfo {BookID = 1,BookName="书1",CateID=203},
                new BookInfo {BookID = 1,BookName="书1",CateID=204},
                new BookInfo {BookID = 1,BookName="书1",CateID=205},
                new BookInfo {BookID = 1,BookName="书1",CateID=206},
                new BookInfo {BookID = 1,BookName="书1",CateID=207},
            };
            var qryres = from b in books
                         join c in Categorys on b.CateID equals c.catID
                         select new
                         {
                             b.BookName,
                             c.catName
                         };
            foreach (var bitem in qryres)
            {
                Console.WriteLine("图书名：{0}，所属分类:{1}", bitem.BookName, bitem.catName);
            }
            Console.WriteLine("abc" == "abc");
            Console.Read() ;
        }
    }
}
