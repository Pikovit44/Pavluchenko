using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository.Interfaces
{
    public interface IBookRepository: IRepository<Book>
    {
        List<Book> GetAvalible();
        List<Book> GetTaken();
        List<Book> GetByTitleAndAuthor(string title, string authors);
        Book GetById(int id);
        void ChangeStatus(int id);
        
        
    }
}
