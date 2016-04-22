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
            Patient person2 = new Patient("John Doe2", "Hearthache");
            Patient person3 = new Patient("John Doe3", "Hearthache");
            Patient person4 = new Patient("John Doe4", "Simulated pain");



            Insurance insuranceCompany = new Insurance();
            insuranceCompany.AddClient(person1);


        }
    }
}
