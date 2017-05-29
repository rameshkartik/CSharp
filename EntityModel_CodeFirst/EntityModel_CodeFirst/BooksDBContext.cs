using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace EntityModel_CodeFirst
{
    public class BooksDBContext:DbContext
    {
        public DbSet<LibraryCategory> LibraryCategories { get; set; }
        public DbSet<LibraryBooks> LibraryBooks { get; set; }
    }
}