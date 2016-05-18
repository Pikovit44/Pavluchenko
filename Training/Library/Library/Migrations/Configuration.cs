namespace Library.Migrations
{
    using Domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DropCreateDatabaseAlways<Library.Data.Context>
    {
        protected override void Seed(Library.Data.Context context)
        {
            if (context.Books.Count() == 0)
            {
                #region Books with single author

                var author1 = new Author("Jon Krakauer");

                var book1 = new Book("Into Thin Air", author1);
                var book3 = new Book("Into Thin Air", author1);
                author1.books.Add(book1);

                var author2 = new Author("Jack Kerouac");
                var book4 = new Book("On the Road", author2);
                var book5 = new Book("On the Road", author2);
                author1.books.Add(book4);
                
                var author3 = new Author("Thor Heyerdahl");
                var book6 = new Book("Kon-Tiki", author3);
                author3.books.Add(book6);

                var author4 = new Author("S. King");

                var author5 = new Author("P. Straub");

                #endregion

                #region Books with multiple authors

                List<Author> authors = new List<Author> { author4, author5 };
                var book7 = new Book("The Talisman", authors);
                #endregion

                context.Authors.AddRange(new List<Author> { author1, author2, author3, author4, author5 });
                context.Books.AddRange(new List<Book> { book1, book3, book4, book5, book6, book7 });
                

                User user = new User("q", "d", false);
                context.Users.Add(user);

                context.SaveChanges();
                base.Seed(context);
            }
        }
    }
}
