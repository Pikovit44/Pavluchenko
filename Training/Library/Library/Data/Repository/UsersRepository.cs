using Domain;
using Library.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class UsersRepository : BaseRepository<User>, IUserRepository
    {
        public UsersRepository(Context db): base(db)
        { }

        public User Create(string login, string email, bool isAdmin)
        {
            User us = new User(login, email, isAdmin);
            db.Users.Add(us);
            db.SaveChanges();
            return us;
        }

        public List<Letter> GetAllLettersByUser(User user)
        {
            return db.Users.FirstOrDefault(u => u.Login == user.Login).Email.Letters.ToList();
        }

        public List<Book> GetTakenBook(User user)
        {
            User us = db.Users.FirstOrDefault(l => l.Login == user.Login);
            return us.Books;
        }

        public bool IsUserExist(string login)
        {
            User us = db.Users.FirstOrDefault(l => l.Login == login);
            return (us != null) ? true : false;
        }

        public bool IsEmailExist(string email)
        {
            User us = db.Users.FirstOrDefault(u => u.Email.Adress == email);
            return (us != null) ? true : false;
        }

        public bool IsUserAdmin(string login)
        {
            User us = db.Users.FirstOrDefault(l => l.Login == login);
            return (us.Administrator) ? true : false;
        }

        public User GetByLogin(string login)
        {
            return db.Users.FirstOrDefault(l => l.Login == login);
        }
        
        public void AddBook(User user, Book book)
        {
            User us = db.Users.FirstOrDefault(l => l.Login == user.Login);
            us.Books.Add(book);
            db.SaveChanges();
        }
        public void RemoveBook(User user, int id)
        {
            User us = db.Users.FirstOrDefault(l => l.Login == user.Login);
            Book bk = db.Books.FirstOrDefault(i => i.Id == id);
            us.Books.Remove(bk);
            db.SaveChanges();
        }
    }
}
