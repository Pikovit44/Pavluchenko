using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public class Person
    {
        Insurance insuranceCompany;
        public Person(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; private set; }
        public Insurance InsuranceCompany { get { return insuranceCompany; } }

        public void InsuranceRegistration(Insurance insurance)
        {
            insuranceCompany = insurance;
        }

    }
}
