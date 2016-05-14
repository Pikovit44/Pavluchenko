using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository.Interfaces
{
    public interface IService
    {
        IBookRepository Books {get;}
        void Dispose();
        void Save();
    }
}
