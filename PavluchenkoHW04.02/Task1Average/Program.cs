using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Average
{
    public delegate float MyDelegate(int x, int y, int z); 
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate MyDelegate = (x, y, z) => (float)(x + y + z) / 3;
            float result = MyDelegate(2,10,4);
            Console.WriteLine(result);
        }
    }
}
