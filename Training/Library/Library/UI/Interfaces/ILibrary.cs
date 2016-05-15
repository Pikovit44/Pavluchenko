using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.Interfaces
{
    public interface ILibrary
    {
        event EventHandler AllBooksClick;
        event EventHandler AvalibleBooksClick;
        event EventHandler TakenBooksClick;
        event EventHandler AddNewBook;
        object BooksBindingSource { set; }
        Book NewBook { get; }
        void Reflesh();
    }
}
