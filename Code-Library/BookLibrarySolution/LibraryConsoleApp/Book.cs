using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    class Book
    {
        public string name;
        public string authorName;
        public int publishedDate;
        int pageCount;

        public int PageCount {
            get
            {
                return pageCount;
            }
            set
            {
                if (value<10)
                {
                    throw new Exception("pageCount standarta uygun deyil.!");
                }
                pageCount = value;
            }
        }

        public override string ToString()
        {
            return $"Name : {name} ," +
                $"AuthorName : {authorName} ," +
                $"PublishedDate : {publishedDate}\n";
               
        }
        public string NewListLabrary()
        {
            return $"Name       : {name}\n" +
                $"AuthorName    : {authorName}\n" +
                $"PublishedDate : {publishedDate}\n" +
                $"PageCount     :{pageCount}\n";
        }

    }
}
