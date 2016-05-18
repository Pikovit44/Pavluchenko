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
        public string AuthorDiscription { get; set; }
        

        public Book(string title, List<Author> authors)
        {
            BaseCtor(title);
            Authors = authors;
            CreateDiscription(Authors);
        }

        public Book(string title, Author author)
        {
            BaseCtor(title);
            Authors.Add(author);
            AuthorDiscription = author.FullName;
        }
        
        public Book() { BaseCtor(string.Empty); }

        void BaseCtor(string title)
        {
            Authors = new List<Author>();
            Title = title;
            AvalibleStatus = true;
        }

        void CreateDiscription(List<Author> authors)
        {
            StringBuilder discr = new StringBuilder();

            for (int i = 0; i < Authors.Count - 1; i++)
            {
                discr.AppendFormat("{0}, ", Authors[i].FullName);
            }
            discr.AppendFormat(" {0}.", Authors[Authors.Count - 1].FullName);
            AuthorDiscription = discr.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}", Title);
        }

    }
}