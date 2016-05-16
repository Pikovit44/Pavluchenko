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
            User us = db.Users.FirstOrDefault(e => e.EMail == email);
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
        
    }
}
