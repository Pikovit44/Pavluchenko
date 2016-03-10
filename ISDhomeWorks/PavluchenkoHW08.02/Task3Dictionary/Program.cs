using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> firstDict = new MyDictionary<int, string>();
            firstDict.Add(1, "model 23");
            firstDict.Add(2, "model 56");
            firstDict.Add(5, "model 3");

            Console.WriteLine(firstDict.Count);
            

        }
    }
}
