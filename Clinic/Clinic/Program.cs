using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient person1 = new Patient("John Doe", "Toothache");

            Insurance insuranceCompany = new Insurance();
            insuranceCompany.AddClient(ref person1);



        }
    }
}
