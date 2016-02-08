using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Facroty
{
    class Program
    {
     
        static void Main(string[] args)
        {
            MyClass<int> w = new MyClass<int>();
            w.FacrotyMethod();            
        }
    }
}
