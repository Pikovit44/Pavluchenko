using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Letter : BaseEntity
    {
        public string Topik { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Letter() { }

        public Letter(string topik, string text, DateTime date)
        {
            Topik = topik;
            Text = text;
            Date = date;
        }

    }
}
