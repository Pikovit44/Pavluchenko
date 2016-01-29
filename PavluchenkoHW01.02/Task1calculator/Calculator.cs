using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1calculator
{
    static public class Calculator
    {


        public static void Addition (int first, int second)
        {   
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine ( first + second);
        }

        public static void Subtraction(int first, int second)
        {
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine(first - second);
        }

        public static void Multiplication(int first, int second)
        {
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine( (float)first * second );
        }

        public static void Division(int first, int second)
        {
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine((float)first / second);
        }


    }
}
