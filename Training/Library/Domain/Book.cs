using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public virtual Author FirstAuthor{ get; set; }
        public virtual Author SecondAuthor { get; set; }
        public virtual Author ThirdAuthor { get; set; }
        public bool AvalibleStatus { get; set; }
        public string authorDiscription { get; set; }
        public Dictionary<DateTime, User> History { get; set; }
        
        public Book(string title, Author first)
        {
            BaseCtor(title);
            FirstAuthor = first;
            authorDiscription = first.FullName;
        }

        public Book(string title, Author first, Author second)
        {
            BaseCtor(title);
            FirstAuthor = first;
            SecondAuthor = second;
            StringBuilder discr = new StringBuilder();
            discr.AppendFormat("{0}, {1}", first.FullName, second.FullName);
            authorDiscription = discr.ToString();
        }

        public Book(string title, Author first, Author second, Author third)
        {
            BaseCtor(title);
            FirstAuthor = first;
            SecondAuthor = second;
            ThirdAuthor = third;
            StringBuilder discr = new StringBuilder();
            discr.AppendFormat("{0}, {1}, {2}", first.FullName, second.FullName, third.FullName);
            authorDiscription = discr.ToString();
        }

        public Book() { }

        void BaseCtor(string title)
        {
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