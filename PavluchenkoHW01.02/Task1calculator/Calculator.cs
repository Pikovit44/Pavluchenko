using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1calculator
{
    static public class Calculator
    {

        static int operation = 0;
        static int firstNum = 0;
        static int secondNum = 0;

        public static void Start()
        {
            Menu1();
            Select();
        }
        public static void Start (int a, int b)
        {
            Menu2(a, b);
            Select();
        }

        public static void Menu1 ()
        {
            firstNum = Helper.EnterInt("Number 1");
            Console.WriteLine("Select a mathematical operation: \n1)+\n2)-\n3)*\n4)\\");
            operation = Helper.EnterMenu("number of menu");
            secondNum = Helper.EnterInt("Number 2");
        }
        public static void Menu2(int a, int b)
        {
            firstNum = a;
            secondNum = b;
            Console.WriteLine("Number one = {0}, number two = {1}", a, b);
            Console.WriteLine("Select a mathematical operation: \n1)+\n2)-\n3)*\n4)\\");
            operation = Helper.EnterMenu("number of menu");
            
        }



        public static void Select()
        {
            switch (operation)
            {
                case 1:
                    Calculator.Addition(firstNum, secondNum);
                    break;
                case 2:
                    Calculator.Subtraction(firstNum, secondNum);
                    break;
                case 3:
                    Calculator.Multiplication(firstNum, secondNum);
                    break;
                case 4:
                    Calculator.Division(firstNum, secondNum);
                    break;
                default:
                    break;
            }
        }

        public static int Addition (int first, int second)
        {   
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine ( first + second);
            return first + second;
        }

        public static int Subtraction(int first, int second)
        {
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine(first - second);
            return first - second;
        }

        public static float Multiplication(int first, int second)
        {
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine( (float)first * second );
            return (float)first * second;
        }

        public static float Division(int first, int second)
        {
            Console.WriteLine("\nAnswer: ");
            Console.WriteLine((float)first / second);
            return (float)first / second;
        }


    }
}
