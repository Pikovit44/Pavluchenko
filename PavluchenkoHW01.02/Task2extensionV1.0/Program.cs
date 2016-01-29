using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2extensionV1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 1, 4, 3, 9 };
            MyClass.MethodSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr [i]);
            }

            Console.WriteLine();

            SmartClass.Sort(arr, false);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
