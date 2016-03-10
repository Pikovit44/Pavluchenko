using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Calculator
{
    public delegate double CalcDel(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            CalcDel Add = (x, y) => x + y;
            CalcDel Sub = (x, y) => x - y;
            CalcDel Mul = (x, y) => x * y;
            CalcDel Div = (x, y) =>
            {
                if (y == 0)
                {
                    Console.WriteLine("You can't divide by zero");
                    return (double)x / y;
                }
                else return (double)x / y;
            };

            int first = Helper.GetInt("First number", int.MinValue, int.MaxValue);

            string[] menuItems = { "+", "-", "*", "/" };
            int operation = Helper.GetMenu(menuItems);

            int second = Helper.GetInt("Second number", int.MinValue, int.MaxValue);
           
            switch (operation)
            {
                case 1:
                    Console.WriteLine(Add(first, second));
                    break;
                case 2:
                    Console.WriteLine(Sub(first, second));
                    break;
                case 3:
                    Console.WriteLine(Mul(first, second));
                    break;
                case 4:
                    Console.WriteLine(Div(first, second));
                    break;

                default:
                    break;
            }

        }
    }
}
