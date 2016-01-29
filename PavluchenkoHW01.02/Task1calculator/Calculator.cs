using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1calculator
{
    static public class Calculator
    {

        public static int Addition (int first, int second)
        {   
            
            Console.WriteLine ( first + second);
            return first + second;
        }

        public static int Subtraction(int first, int second)
        {
         
            Console.WriteLine(first - second);
            return first - second;
        }

        public static float Multiplication(int first, int second)
        {
       
            Console.WriteLine( (float)first * second );
            return (float)first * second;
        }

        public static float Division(int first, int second)
        {
            if (second == 0)
                Console.WriteLine("Error. You can't divide by zero");
                Console.WriteLine((float)first / second);
                return (float)first / second;
            
        }


    }
}
