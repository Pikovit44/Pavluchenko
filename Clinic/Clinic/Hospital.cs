using Clinic.Doctors;
using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{

    public enum Doctor
    {
        Unknown,
        Dentist,
        ENT,
        Podiatrist
    }

    public class Hospital
    {
        Dentist dentist;
        ENT ent;
        Podiatrist podiatrist;
        Dictionary<string, Doctor> complaintsDoctors;
        Dictionary<string, decimal> treatmentsBills;
        Patient currentPatient;
        Doctor currentDoctorType;
        BaseDoctor currentDoctor;
        string currentTreatment;
        decimal currentSum;
        bool currentBill;


        public Hospital()
        {

            complaintsDoctors = new Dictionary<string, Doctor>
            {
                {"Dentistcomplaint1", Doctor.Dentist},
                {"Dentistcomplaint2", Doctor.Dentist},
                {"Dentistcomplaint3", Doctor.Dentist},
                {"ENTcomplaint1", Doctor.ENT},
                {"ENTcomplaint2", Doctor.ENT},
                {"ENTcomplaint3", Doctor.ENT},
                {"Podiatristcomplaint1", Doctor.Podiatrist},
                {"Podiatristcomplaint2", Doctor.Podiatrist},
                {"Podiatristcomplaint3", Doctor.Podiatrist}
            };

            treatmentsBills = new Dictionary<string, decimal>
            {
                {"Dentistdiagnosise1", (decimal)200.00},
                {"Dentistdiagnosise2", (decimal)280.00},
                {"ENTdiagnosise1", (decimal)500.00},
                {"ENTdiagnosise2", (decimal)170.00},
                {"Podiatristdiagnosise1", (decimal)200.00},
                {"Podiatristdiagnosise2", (decimal)890.00}
            };
        }

        public void AddDoctor(BaseDoctor doctor)
        {
            if (doctor is Dentist)
            {
                dentist = (Dentist)doctor;
            }
            if (doctor is ENT)
            {
                ent = (ENT)doctor;
            }
            if (doctor is Podiatrist)
            {
                podiatrist = (Podiatrist)doctor;
            }
        }

        public void Reception(Patient patient)
        {
            currentPatient = patient;
            ChooseDoctor();
            SendToTheDoctor();
        }

        void ChooseDoctor()
        {
            currentDoctorType = Doctor.Unknown;
            foreach (var compDoct in complaintsDoctors)
            {
                if (compDoct.Key == currentPatient.Complaint)
                {
                    currentDoctorType = compDoct.Value;
                    break;
                }
            }
        }

        void SendToTheDoctor()
        {
            currentTreatment = string.Empty;
            switch (currentDoctorType)
            {
                case Doctor.Unknown:
                    break;
                case Doctor.Dentist:
                    currentDoctor = dentist;
                    currentTreatment = dentist.Diagnosise(currentPatient);
                    break;
                case Doctor.ENT:
                    currentDoctor = ent;
                    currentTreatment = ent.Diagnosise(currentPatient);
                    break;
                case Doctor.Podiatrist:
                    currentDoctor = podiatrist;
                    currentTreatment = podiatrist.Diagnosise(currentPatient);
                    break;
                default:
                    break;
            }
        }

        public CashAccount CreateBill( )
        {
            ChooseSum();
            CashAccount currentBill = new CashAccount(DateTime.Now, currentPatient.FullName, currentTreatment, currentSum);
            return currentBill;
        }

        public bool ChecBill(CashAccount bill)
        {
            if (bill.Status == "paid")
            {
                return true;
            }
            return false;
        }

        public void Treatment()
        {
            currentDoctor.Treatment(ref currentPatient);
        }

        void ChooseSum()
        {
            currentSum = 0;
            foreach (var trBill in treatmentsBills)
            {
                if (trBill.Key == currentTreatment)
                {
                    currentSum = trBill.Value;
                    break;
                }
            }
        }



    }
}
