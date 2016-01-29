using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = Helper.EnterInt("Number 1");
            Console.WriteLine("Select a mathematical operation: \n1)+\n2)-\n3)*\n4)\\");
            int operation = Helper.EnterMenu("menu");
            int secondNum = Helper.EnterInt("Number 2");

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
    }
}
