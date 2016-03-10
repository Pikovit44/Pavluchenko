using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5AutoPark
{
    class Program
    {
        public struct Car
        {
            public string Model;
            public int YearOfRel;
        }

        static void Main(string[] args)
        {
            Car nissan;
            nissan.Model = "Maxima";
            nissan.YearOfRel = 2000;

            Car toyota;
            toyota.Model = "Prado";
            toyota.YearOfRel = 2010;

            CarCollection<Car> dpPark = new CarCollection<Car>();
            dpPark.Add(nissan);
            dpPark.Add(toyota);

            Console.WriteLine(dpPark.Count);

            Console.WriteLine(dpPark[1].Model);
            Console.WriteLine(dpPark[1].YearOfRel);

            dpPark.Del();

            Console.WriteLine(dpPark.Count);
            

        }
    }
}
