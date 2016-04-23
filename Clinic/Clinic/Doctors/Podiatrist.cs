using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public class Podiatrist : BaseDoctor
    {
        public Podiatrist(string fullName) : base (fullName)
        {
            diagnosises = new Dictionary<string, string>
            {
                {"Podiatristcomplaint1", "Podiatristdiagnosise1"},
                {"Podiatristcomplaint2", "Podiatristdiagnosise2"},
                {"Podiatristcomplaint3", "Podiatristdiagnosise2"}
            };
        }
    }
}
