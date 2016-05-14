using Library.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class Service : IService
    {
        private readonly Context db;
        private IBookRepository bookRepository;

        public Service ()
        {
            db = new Context();
        }

        public IBookRepository Books
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new BooksRepository(db);
                }
                return bookRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
