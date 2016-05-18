namespace Library.Data
{
    using Domain;
    using Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Context: DbContext
    {
        public Context()
            : base("name=LibraryDBContextModel")
        {
         Database.SetInitializer<Context>(new Configuration());
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Domain.Action> Actions { get; set; }
        public DbSet<Letter> Emails { get; set; }
    }

    
}