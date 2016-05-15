using Domain;
using Library.Data.Repository;
using Library.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI
{
    public class Presenter
    {
        Service servise;
        List<Book> books;
        ILibrary library;

        public Presenter(ILibrary library)
        {
            this.library = library;
            servise = new Service();
            library.AllBooksClick += Library_AllBooksClick;
            library.AvalibleBooksClick += Library_AvalibleBooksClick;
            library.TakenBooksClick += Library_TakenBooksClick;
            library.AddNewBook += Library_AddNewBook;
            books = servise.Books.GetAll().ToList();
            library.BooksBindingSource = books;
        }

        private void Library_AddNewBook(object sender, EventArgs e)
        {
            servise.Books.Create(library.NewBook);
            servise.Save();
        }

        private void Library_TakenBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetTaken().ToList();
            library.BooksBindingSource = books;
        }

        private void Library_AvalibleBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetAvalible().ToList();
            library.BooksBindingSource = books;
        }

        private void Library_AllBooksClick(object sender, EventArgs e)
        {
            books = servise.Books.GetAll().ToList();
            library.BooksBindingSource = books;
        }
    }
}
