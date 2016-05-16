using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        User Create(string login, string email, bool isAdmin);
        List<Book> GetTakenBook(User user);
        bool IsUserExist(string login);
        bool IsEmailExist(string login);
        bool IsUserAdmin(string login);
        User GetByLogin(string login);
        void AddBook(User user, Book book);
        void RemoveBook(User user, int id);
    }
}
