using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4extension
{
    public static class MyReplace
    {
        public static string MyReplMeth (string myString, string oldValue, string newValue)
        {
            Console.WriteLine("Method MyReplbMethod is working");
            return myString.Replace(oldValue, newValue); 
        }
    }
}
