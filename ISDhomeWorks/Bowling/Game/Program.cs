using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
        }
    }

    class A
    {
        public void Method()
        {
            Console.WriteLine("Method a");
        }
    }
    class B: A
    {
        public new void  Method()
        {
            Console.WriteLine("Method b");
        }


    }
}
