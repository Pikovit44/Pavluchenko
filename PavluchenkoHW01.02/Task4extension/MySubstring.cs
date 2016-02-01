using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4extension
{
    public static class MySubstring
    {
        public static string MySubMethod(string myString, int start, int length)
        {
            Console.WriteLine("Method MySubMethod is working");
            return myString.Substring(start, length);
        }
    }
}
