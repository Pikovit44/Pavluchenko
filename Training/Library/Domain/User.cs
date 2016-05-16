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
        public List<string> Letters { get; set; }
        public List<Book> Books { get; set; }

        public User(string login, string email, bool isAdmin)
        {
            Login = login;
            EMail = email;
            Administrator = isAdmin;
            Letters = new List<string>();
            Books = new List<Book>();
        }

        public User ()
        { }

        public override string ToString()
        {
            return string.Format("{0}", Login );
        }
    }
}
