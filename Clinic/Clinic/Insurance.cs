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
            List<string> reasons = new List<string> { "Treatment of headache", "Treatment of heartache", "Treatment of headache" };
        }

        public void AddClient(Patient client)
        {
            if (ClientIsPresent(client) == false)
            {
                clients.Add(client);
            }
        }

        public void BillPayment( ref CashAccount account)//?
        {
            if (validReason && validFulName)
            {
                account.Status = "payment";
            }
        }

        bool ClientIsPresent(Patient client)
        {
            bool clientIsPresent = false;

            foreach (var cl in clients)
            {
                if (cl.FullName == client.FullName)
                {
                    clientIsPresent = true;
                    break;
                }
            }
            return clientIsPresent;
        }

        void Validation(CashAccount account)
        {
            ReasonValidation(account);
            FullNameValidation(account);
        }

        void ReasonValidation(CashAccount account)
        {
            validReason = false;
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
            validFulName = false;
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
