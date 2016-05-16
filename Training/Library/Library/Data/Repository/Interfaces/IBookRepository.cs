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
        void ChangeStatus(int id);
        Book GetById(int id);
    }
}
