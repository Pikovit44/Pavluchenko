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
            
        public List<Book> GetAvalible()
        {
            return db.Books.Where( s => s.AvalibleStatus == true).ToList();
        }

        public List<Book> GetTaken()
        {
            return db.Books.Where(s => s.AvalibleStatus == false).ToList();
        }
    }
}
