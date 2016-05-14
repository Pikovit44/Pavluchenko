using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UI.Interfaces
{
    public interface ILibrary
    {
        bool IsAdmin { get; }
        event EventHandler LoadLibrary;
        object BooksBindingSource { set; }
    }
}
