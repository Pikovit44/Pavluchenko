using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList test = new MyList();
            test.Add(4);
            test.Add(34);
            test.Add(44);

            foreach (int item in test)
            {
                Console.WriteLine(item);
            }
        }
    }
}
