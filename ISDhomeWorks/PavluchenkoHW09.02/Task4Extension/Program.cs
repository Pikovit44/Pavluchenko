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
            MyList<string> test = new MyList<string>();
            test.Add("text 1");
            test.Add("text 2");
            test.Add("text 3");

            test.GetArray();
        }
    }
}
