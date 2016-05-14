namespace Library.Data
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context : DbContext
    {
       
        public Context()
            : base("name=LibraryDBContextModel")
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }

    }

    
}