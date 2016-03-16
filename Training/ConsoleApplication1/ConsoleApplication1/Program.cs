using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Method();
            B n = new B();
            n.Method();

        }
    }

    class A
    {
        public void Method()
        {
            Console.WriteLine("Method a");
        }
    }
    class B:A
    {
        public new void Method()
        {
            Console.WriteLine("Method b");
        }
    }


}
