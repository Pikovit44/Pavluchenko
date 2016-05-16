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
        event EventHandler TakeBook;
        event EventHandler OkReturnClick;
        object BooksBindingSource { set; }
        Book NewBook { get; }
        Book SelectedBook { get; }
        int ReturnId { get; }
        void Reflesh();
        void InfoForHistoryTake();
        void InfoForReturn(Book book);
    }
}
