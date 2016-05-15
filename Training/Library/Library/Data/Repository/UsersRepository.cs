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

        public List<Book> GetTakenBook(User user)
        {
            return user.Books;
        }
    }
}
