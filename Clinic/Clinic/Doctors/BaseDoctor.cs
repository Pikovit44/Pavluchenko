using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public abstract class BaseDoctor: Person
    {
        protected string currentComplaint;
        protected List<string> complaints;
        protected List<string> diagnosises;

        public BaseDoctor(string fullName) : base (fullName)
        {

        }

        public abstract string Diagnosise(Patient patient);
    }
}
