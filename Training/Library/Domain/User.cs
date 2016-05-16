using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string EMail { get; set; }
        public bool Administrator { get; set; }
        public Dictionary<DateTime, Book> History { get; set; }
        public List<string> Letters { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Login );
        }
    }
}
