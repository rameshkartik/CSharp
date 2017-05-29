using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityModel_CodeFirst
{
    public class LibraryCategory
    {
        public int Id { get; set; }
        public string Category {get;set;}
        public int NoOfBooks { get; set; }
        public List<LibraryBooks> Books { get; set; }

    }
}