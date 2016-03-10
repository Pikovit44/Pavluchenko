using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ListForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> first = new MyList<int>();
            first.Add(2);
            first.Add(4);
            first.Add(6);

            foreach (int item in first)
            {
                Console.WriteLine(item);
            }
        }
    }
}
