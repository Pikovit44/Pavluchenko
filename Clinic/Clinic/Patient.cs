using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Patient : Person, IPatient
    {

        public Patient(string fullName, string complaint) : base ( fullName )
        {
            Complaint = complaint;
        }

        public string Complaint
        { get; private set; }
        
    }
}
