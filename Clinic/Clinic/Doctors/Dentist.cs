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
        Dictionary<string, string> diagnosises;
        public Dentist(string fullName) : base (fullName)
        {
            diagnosises = new Dictionary<string, string>
            {
                {"Dentistcomplaint1", "Dentistdiagnosise1"},
                {"Dentistcomplaint2", "Dentistdiagnosise1"},
                {"Dentistcomplaint3", "Dentistdiagnosise2"}
            };
        }
        
        public override string Diagnosise(Patient patient)
        {
            currentComplaint = string.Empty;
            foreach (var item in diagnosises)
            {
                if (item.Key == patient.Complaint)
                {
                    currentComplaint = item.Value;
                    break;
                }
            }
            return currentComplaint;
        }
        

    }
}
