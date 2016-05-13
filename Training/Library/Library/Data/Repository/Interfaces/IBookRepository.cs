using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository.Interfaces
{
    interface IBookRepository: IRepository<Book>
    {
        IEnumerable<Book> GetAvalible();
        IEnumerable<Book> GetTaken();
        void Delete(string title, string author);
    }
}
