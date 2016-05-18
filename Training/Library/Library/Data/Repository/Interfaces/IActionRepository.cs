using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository.Interfaces
{
    public interface IActionRepository : IRepository<Domain.Action>
    {
        string GetLastOwnerLoginByBook(Book book);
        List<Domain.Action> GetAllActionsByBook(Book book);
        List<Domain.Action> GetAllActionsByBooks(Book book);
    }
}
