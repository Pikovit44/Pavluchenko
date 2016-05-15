using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public virtual List<Book> books { get; set; }

        public Author(string fullName)
        {
            FullName = fullName;
            books = new List<Book>();
        }

        public Author() { }

        public override string ToString()
        {
            return string.Format("{0}", FullName);
        }

    }
}
