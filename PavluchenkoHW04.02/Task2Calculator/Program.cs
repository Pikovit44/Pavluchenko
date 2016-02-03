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
                    Console.WriteLine("You can not divide by zero");
                    return (double)x / y;
                }
                else return (double)x / y;
            };

            int first = Helper.GetInt("First number", int.MinValue, int.MaxValue);

            string[] menuItems = { "+", "-", "*", "/" };
            int operation = Helper.GetMenu(menuItems);

            int second = Helper.GetInt("Second number", int.MinValue, int.MaxValue);
            double result = 0; 
            switch (operation)
            {
                case 1:
                    result = Add(first, second);
                    break;
                case 2:
                    result = Sub(first, second);
                    break;
                case 3:
                    result = Sub(first, second);
                    break;
                case 4:
                    result = Div(first, second);
                    break;

                default:
                    break;
            }

            Console.WriteLine(result);

            Console.WriteLine(Div(2,0));
            

        }
    }
}
