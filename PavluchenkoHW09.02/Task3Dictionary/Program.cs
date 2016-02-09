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
            MyDictionary<int, string> test = new MyDictionary<int, string>();
            test.Add(1, "Test 1");
            test.Add(2, "Test 2");
            test.Add(4, "Test 4");

            //foreach (var item in test)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
