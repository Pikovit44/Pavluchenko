using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your birthay date (month and day, for example: 3 29)");
            int year = DateTime.Now.Year, month = Helper.EnterMonth("month"), day = Helper.EnterDay("day");
            DateTime birthDay = new DateTime(year, month, day);

            

            TimeSpan timeBeforeBd = birthDay - DateTime.Now; // вопрос про отрицательные значения
            Console.WriteLine(timeBeforeBd.Days);
        }

        
        
    }
}
