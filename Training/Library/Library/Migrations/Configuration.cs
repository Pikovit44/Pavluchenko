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

                var author1 = new Author("Name1");

                var book1 = new Book("Title1", author1);
                author1.books.Add(book1);

                //var book2 = new Book("Title2", author1);
                //author1.books.Add(book2);
                //var book3 = new Book("Title3", author1);
                //author1.books.Add(book3);

                

                var author2 = new Author("Name2");
                var book4 = new Book("Title4", author2);
                author1.books.Add(book4);
                //var book5 = new Book("Title5", author2);
                //author1.books.Add(book3);

                var author3 = new Author("Name3");
                var book6 = new Book("Title6", author3);
                author3.books.Add(book6);
                //var book7 = new Book("Title7", author2);
                //author1.books.Add(book3);
                //var book8 = new Book("Title8", author2);
                //author1.books.Add(book1);
                //var book9 = new Book("Title9", author2);
                //author1.books.Add(book3);


                #endregion

                #region Books with multiple authors

                List<Author> authors = new List<Author> { author1, author3 };
                var book7 = new Book("Title10", authors);
                #endregion

                context.Authors.AddRange(new List<Author> { author1, author2, author3 });
                context.Books.AddRange(new List<Book> { book1, book4, book6, book7});

                User user = new User("q", "d", false);
                context.Users.Add(user);

                context.SaveChanges();
                base.Seed(context);
            }
        }
    }
}
