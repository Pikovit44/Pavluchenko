using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> first = new MyList<int>();
            first.Add(3);
            first.Add(5);

            Console.WriteLine(
                "First element:{0}, second element:{1}, count of elements:{2}" , first[0] , first[1], first.Count);

        }
    }
}
