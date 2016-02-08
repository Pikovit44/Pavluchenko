using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Extension
{
    class Program
    {
        

        static void Main(string[] args)
        {
            MyList<string> firstText = new MyList<string>();
            firstText.Add("text1");
            firstText.Add("text2");
            firstText.Add("text3");

            firstText.GetArray();
        }
    }
}
