using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Action : BaseEntity
    {
        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public Action()
        {
        }
        
        public Action(DateTime date, User user, Book book, bool status)
        {
            Date = date;
            User = user;
            Book = book;
            Status = status;
        }
    }
}
