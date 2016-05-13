using Domain;
using Library.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    class BooksRepository : BaseRepository<Book>, IBookRepository
    {
        public BooksRepository(Context db) : base(db)
        { }

        public void Delete(string title, string author)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAvalible()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetTaken()
        {
            throw new NotImplementedException();
        }
    }
}
