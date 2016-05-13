using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string EMail { get; set; }
        public Dictionary<DateTime, Book> History { get; set; }
        public List<string> Letters { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Login );
        }
    }
}
