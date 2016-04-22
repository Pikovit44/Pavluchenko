using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Insurance
    {
        List<Patient> clients;
        List<string> reasons;
        bool validFulName;
        bool validReason;

        public Insurance()
        {
            clients = new List<Patient>();
            reasons = new List<string>();
        }

        public void AddClient(ref Patient client)
        {
            Person person = clients.FirstOrDefault();//!!!
            if (person == null)
            {
                clients.Add(client);
                client.InsuranceRegistration(this);
            }

        }

        public void BillPayment( ref CashAccount account)//?
        {
            if (validReason && validFulName)
            {
                account.Status = "payment";
            }
        }

        void Validation(CashAccount account)
        {
            ReasonValidation(account);
            FullNameValidation(account);
        }

        void ReasonValidation(CashAccount account)
        {
            foreach (var reason in reasons)
            {
                if (reason == account.Discription.Reason)
                {
                    validReason = true;
                    break;
                }
            }
        }

        void FullNameValidation(CashAccount account)
        {
            foreach (var client in clients)
            {
                if (client.FullName == account.Discription.ClientFullName)
                {
                    validFulName = true;
                    break;
                }
            }
        }
    }
}
