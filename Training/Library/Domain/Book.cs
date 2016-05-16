using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public virtual List<Author> Authors { get; set; }
        public bool AvalibleStatus { get; set; }
        public string authorDiscription { get; set; }
        public Dictionary<DateTime, User> History { get; set; }

        public Book(string title, List<Author> authors)
        {
            BaseCtor(title);
            Authors = authors;
            StringBuilder discr = new StringBuilder();
            foreach (var auth in Authors)
            {
                discr.AppendFormat("{0}, ", auth.FullName);
            }
            authorDiscription = discr.ToString();
        }

        public Book(string title, Author author)
        {
            BaseCtor(title);
            Authors.Add(author);
            authorDiscription = author.FullName;
        }
        
        public Book() { }

        void BaseCtor(string title)
        {
            Authors = new List<Author>();
            Title = title;
            AvalibleStatus = true;
            History = new Dictionary<DateTime, User>();
        }
        public override string ToString()
        {
            return string.Format("{0}", Title);
        }

    }
}