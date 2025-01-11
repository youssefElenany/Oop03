using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    public class EBook : Book
    {
        public double FileSize { get; set; }
    }

    public class PrintedBook : Book
    {
        public int PageCount { get; set; }
    }


}
