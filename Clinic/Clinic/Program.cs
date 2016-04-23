using Clinic.Doctors;
using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    class Program
    {
        static void Main(string[] args)
        {


            #region SetUp
            Patient person1 = new Patient("John Doe", "Dentistcomplaint2");
            //Person person2 = new Patient("John Doe2", "Hearthache");
            //Person person3 = new Patient("John Doe3", "Hearthache");
            //Person person4 = new Patient("John Doe4", "Simulated pain");

            Hospital hospital = new Hospital();
            hospital.AddDoctor(new Dentist("Doctor Doctorus"));
            hospital.AddDoctor(new Dentist("Doctor Doctorusus"));
            hospital.AddDoctor(new Dentist("Doctor Doctorusis"));


            Insurance insuranceCompany = new Insurance();

            insuranceCompany.AddClient(person1);
            #endregion

            Console.WriteLine(person1.Complaint);

            hospital.Reception(person1);
            
            CashAccount cashAccount =  hospital.CreateBill();
            insuranceCompany.BillPayment(ref cashAccount);

            if (hospital.ChecBill(cashAccount))
            {
                hospital.Treatment();
            };

            Console.WriteLine(person1.Complaint);
            
        }
    }
}
