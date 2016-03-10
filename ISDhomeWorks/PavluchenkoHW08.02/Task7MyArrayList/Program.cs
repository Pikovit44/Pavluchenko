using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7MyArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList first = new MyArrayList();
            first.Add(5);
            first.Add("test");
            first.Add(true);

            Console.WriteLine(first.Capacity);
            Console.WriteLine(first.Count);

            Console.WriteLine(first[2]);
            Console.WriteLine(first[2].GetType()); 


        }
    }
}
