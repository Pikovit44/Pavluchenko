using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class InsuranceCompany : IInsuranceCompany
    {
        List<Person> clients;
        Dictionary<string, decimal> caseLimit;
        bool validFulName;
        bool validCase;
        bool validLimit;
        Bill currentBill;
        decimal shortfall;

        public InsuranceCompany()
        {
            clients = new List<Person>();

            caseLimit = new Dictionary<string, decimal>
            {
                {"Dentistdiagnosise1", (decimal)300.00},
                {"Dentistdiagnosise2", (decimal)380.00},
                {"ENTdiagnosise1", (decimal)600.00},
                {"ENTdiagnosise2", (decimal)270.00},
                {"Podiatristdiagnosise1", (decimal)300.00},
                {"Podiatristdiagnosise2", (decimal)790.00}
            };
        }

        public void AddClient(Person client)
        {
            if (ClientInBase(client) == false)
            {
                clients.Add(client);
            }
        }

        public void AddRangeClients(List<Person> clients)
        {
            foreach (var client in clients)
            {
                AddClient(client);
            }
        }

        public void BillPayment( ref Bill bill)
        {
                currentBill = bill;
                Validation();
                if (validCase && validFulName)
                {
                    if (validLimit)
                    {
                        bill.Status = "payment";
                    }
                    else
                    {
                        StringBuilder s = new StringBuilder();
                        s.AppendFormat(" Shortfall is {0}", shortfall);
                        bill.Status = s.ToString();
                    }
                }
        }

        bool ClientInBase(Person client)
        {
            bool clientInBase = false;

            foreach (var cl in clients)
            {
                if (cl.FullName == client.FullName)
                {
                    clientInBase = true;
                    break;
                }
            }
            return clientInBase;
        }

        void Validation()
        {
            CaseValidation();
            FullNameValidation();
        }

        void SumValidation(decimal bill, decimal limit)
        {
            if (bill <= limit)
            {
                validLimit = true;
            }
            else
            {

                validLimit = false;
                shortfall = bill - limit;
            }
        }

        void CaseValidation()
        {
            validCase = false;
            foreach (var caseSum in caseLimit)
            {
                if (caseSum.Key == currentBill.Case)
                {
                    SumValidation(currentBill.Sum, caseSum.Value);
                    validCase = true;
                    break;
                }
            }
        }

        void FullNameValidation()
        {
            validFulName = false;
            foreach (var client in clients)
            {
                if (client.FullName == currentBill.ClientFullName)
                {
                    validFulName = true;
                    break;
                }
            }
        }
    }
}
