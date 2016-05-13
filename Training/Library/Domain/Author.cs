using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public virtual List<Book> books { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", FullName);
        }

    }
}
