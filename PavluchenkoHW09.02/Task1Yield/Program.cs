using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrey = { 1, 2, 7, 8, 9, 23 };
            EvenList first = new EvenList();
            MyList<int> evenList =  first.GetEvenList(arrey);

            foreach (int  item in evenList)
            {
                Console.WriteLine(item);
            }

            
        }
    }

   
}
