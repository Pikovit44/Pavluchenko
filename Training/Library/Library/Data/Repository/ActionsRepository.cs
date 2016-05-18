using Domain;
using Library.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class ActionsRepository : BaseRepository<Domain.Action>, IActionRepository
    {
        public ActionsRepository(Context db):base(db)
        {

        }
        public List<Domain.Action> GetAllActionsByBook(Book book)
        {
            return db.Actions.Where(b => b.Book.Id == book.Id).ToList();
        }

        public List<Domain.Action> GetAllActionsByBooks(Book book)
        {
            return db.Actions.Where(b => b.Book.Title == book.Title).Where(i => i.Book.AuthorDiscription == book.AuthorDiscription).ToList();
        }

        public string GetLastOwnerLoginByBook(Book book)
        {
            List<Domain.Action> actions = db.Actions.Where(b => b.Book.Id == book.Id).ToList();
            string login = actions.Last().User.Login;
            return login;
        }
    }
}
