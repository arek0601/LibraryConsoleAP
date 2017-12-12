using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProgramConsole.Domain
{
    public class Book
    {
        public string Title { get; set; }

        public int PageCount { get; set; }

        public BookType Type { get; set; }

        public Book(string title, int pageCount, BookType type)
        {
            Title = title;
            PageCount = pageCount;
            Type = type;
        }
    }
}
