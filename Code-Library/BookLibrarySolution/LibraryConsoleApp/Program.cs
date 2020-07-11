using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Library = new Book();
            Library.name = "Qerb burkusu";
            Library.authorName = "Çingiz Abdullayev";
            Library.publishedDate = 2013;
            Library.PageCount = 13;

            Console.WriteLine(Library);
            
            List<Book> NewLibrary = new List<Book>();
            NewLibrary.Add(new Book()
            {
                name = "Etiraflar vadisi",
                authorName = "Çingiz Abdullaye",
                publishedDate = 2009,
                PageCount = 250
            });

            NewLibrary.Add(new Book()
              {
                  name = "George Orwell",
                  authorName = "Corc Oruell",
                  publishedDate = 2009,
                  PageCount = 174
              });

            NewLibrary.Add(new Book()
            {
                name = "Lev Tolstoy",
                authorName = "Anna Karenina",
                publishedDate = 1878,
                PageCount = 124
            });

            NewLibrary.Add(new Book()
            {
               name = "Lev Tolstoy",
               authorName = "Anna Karenina",
               publishedDate = 1878,
               PageCount = 124,
        });

            for (int i = 0; i < NewLibrary.Count; i++)
            {
                Console.WriteLine(NewLibrary[i].NewListLabrary());
            }

            Console.ReadKey();
        }
    }
}
