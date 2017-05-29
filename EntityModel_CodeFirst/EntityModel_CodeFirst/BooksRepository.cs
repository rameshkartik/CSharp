using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityModel_CodeFirst
{
    public class BooksRepository
    {
        public List<LibraryCategory> LibraryCategories()
        {
            BooksDBContext bkDBContext = new BooksDBContext();
            return bkDBContext.LibraryCategories.ToList();
        }

        public List<LibraryBooks> LibraryBooks()
        {
            BooksDBContext bkDBContext = new BooksDBContext();
            return bkDBContext.LibraryBooks.ToList();
        }
    }
}