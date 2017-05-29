using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityModel_CodeFirst
{
    public class LibraryBooks
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int price { get; set; }
        public LibraryCategory Category { get; set; }
    }
}