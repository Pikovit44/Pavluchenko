using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Doctors
{
    public class ENT : BaseDoctor
    {
        public ENT(string fullName) : base (fullName)
        {
            diagnosises = new Dictionary<string, string>
            {
                {"ENTcomplaint1", "ENTdiagnosise1"},
                {"ENTcomplaint2", "ENTdiagnosise1"},
                {"ENTcomplaint3", "ENTdiagnosise2"}
            };
        }
    }
}
