using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5, 12, 34, 2, 4 };
            var posNums = from n in nums
                          where n > 0
                          where n > 2
                          orderby n descending
                          select Math.Sqrt(n) ;
            Console.WriteLine("Положительные значения меньше 10 из массива nums: ");

            foreach (int i in posNums)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        }
    }
}
