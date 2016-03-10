using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4extension
{
    public static class MyIndexOf
    {
        public static int MyIndexMethod (string mystring, string toFind)
        {
            Console.WriteLine("Method MyIndexMethod is working");
            return mystring.IndexOf(toFind);
        }
    }
}
