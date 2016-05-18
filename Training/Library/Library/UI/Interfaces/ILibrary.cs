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
        event EventHandler TableClick;
        event EventHandler LastOwner;
        event EventHandler HistoryForBook;
        event EventHandler HistoryForBooks;
        event EventHandler RemoveBook;

        object BooksBindingSource { set; }
        Book NewBook { get; }
        Book SelectedBook { get; }
        int ReturnId { get; }
        int CountOfAvalibleBook { set; }
        int CountOfBook { set; }
        bool AllBook { set; }
        bool AvalibleBook { set; }
        InfoType OutputInfo { get; }
        string Owner { set; }
        List<Domain.Action> BooksActions { set; }
    }
}
