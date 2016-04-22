using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public enum TypeOfDoctor
    {
        ENT,
        Dentist,
        Podiatrist
    }
    public static class Constants
    {
        

        public static List<string> complaintsForENT = new List<string> { "complaintsForENT1", "complaintsForENT2", "complaintsForENT3" };
        public static List<string> complaintsForDentist = new List<string> { "complaintsForDentist1", "complaintsForDentist2", "complaintsForDentist3" };
        public static List<string> complaintsForPodiatrist = new List<string> { "complaintsForPodiatrist1", "complaintsForPodiatrist2" };

        public static List<string> diagnosisesForENT = new List<string> { "Diagnosise1", "Diagnosise2" };
        public static List<string> diagnosisesForDentist = new List<string> { "Diagnosise1", "Diagnosise2" };
        public static List<string> diagnosisesForPodiatrist = new List<string> { "Diagnosise1", "Diagnosise2" };
        
    }



}
