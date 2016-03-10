using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5PrintString
{

    public enum Colour : byte
    {
        Blue,
        Green,
        Red
    };


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose colour: \n1.Blue\n2.Green\n3.Red");
            int menuItem =  Helper.EnterMenu("menu item");
            PrintString.Print("test", menuItem );
            
        }
    }
}
