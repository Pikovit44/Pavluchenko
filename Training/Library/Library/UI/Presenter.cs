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
            library.LoadLibrary += Library_LoadLibrary;
            servise = new Service();
            books = servise.Books.GetAll().ToList();
            library.BooksBindingSource = books;

        }

        private void Library_LoadLibrary(object sender, EventArgs e)
        {
            
        }


    }
}
