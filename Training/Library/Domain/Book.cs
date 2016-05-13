using System;
using System.Collections.Generic;

namespace Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Author> Authots { get; set; }
        public Dictionary<DateTime, User> History { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Title);
        }

    }
}