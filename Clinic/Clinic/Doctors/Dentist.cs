using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public class Dentist : BaseDoctor
    {
        
        public Dentist(string fullName) : base (fullName)
        {
            diagnosises = new Dictionary<string, string>
            {
                {"Dentistcomplaint1", "Dentistdiagnosise1"},
                {"Dentistcomplaint2", "Dentistdiagnosise2"},
                {"Dentistcomplaint3", "Dentistdiagnosise2"}
            };
        }
        
    }
}
