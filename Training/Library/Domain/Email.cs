using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Email: BaseEntity
    {
        public List<Letter> Letters { get; set; }
        public string Adress { get; set; }
        
        public Email(string adress)
        {
            Letters = new List<Letter>();
            Adress = adress;
        }

        public Email()
        {
            Adress = string.Empty;
            Letters = new List<Letter>();
        }

        public void AddLetter(Letter letter)
        {
            Letters.Add(letter);
        }


    }
}
