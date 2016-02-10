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
            int[] arr = new int [25];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            EvenList test = new EvenList();

                

            foreach (int item in test.GetEvenClass(arr))
            {
                Console.WriteLine( item );
            }

         

        }

    }

   
}
