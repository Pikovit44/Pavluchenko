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

            Calculator.Addition(5, 10);
            Calculator.Subtraction(0, 10);
            Calculator.Multiplication(5, 20);
            Calculator.Division(20, 0);

        }
    }
}
