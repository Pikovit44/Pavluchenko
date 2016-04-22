using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public class Doctor: Person, IDoctor
    {
        List<string> complaints;
        public Doctor (string fullName, TypeOfDoctor type) : base (fullName)
        {
            FillComplaints(type);
            FillDiagnosises(type);
        }

        void FillDiagnosises(TypeOfDoctor type)
        {

            switch (type)
            {
                case TypeOfDoctor.ENT:
                    complaints = Constants.diagnosisesForENT;
                    break;
                case TypeOfDoctor.Dentist:
                    complaints = Constants.diagnosisesForDentist;
                    break;
                case TypeOfDoctor.Podiatrist:
                    complaints = Constants.complaintsForPodiatrist;
                    break;
                default:
                    break;
            }
        }

        void FillComplaints(TypeOfDoctor type)
        {
            switch (type)
            {
                case TypeOfDoctor.ENT:
                    complaints = Constants.complaintsForENT;
                    break;
                case TypeOfDoctor.Dentist:
                    complaints = Constants.complaintsForDentist;
                    break;
                case TypeOfDoctor.Podiatrist:
                    complaints = Constants.complaintsForPodiatrist;
                    break;
                default:
                    break;
            }
        }

        public string Diagnosise(Patient patient)
        {
            throw new NotImplementedException();
        }


    }
}
