using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "test string";
            string testMySub = MySubstring.MySubMethod(testString, 2, 7);
            Console.WriteLine(testMySub);

            
            int myIndexOf = MyIndexOf.MyIndexMethod(testString, "st");
            Console.WriteLine(myIndexOf);

            testString = MyReplace.MyReplMeth(testString, "st", "BB");
            Console.WriteLine(testString);

        }
    }
}
