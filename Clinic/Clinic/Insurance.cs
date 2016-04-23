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
        List<Person> clients;
        Dictionary<string, decimal> reasonsSum;
        bool validFulName;
        bool validReason;
        bool validSum;
        CashAccount currentAccount;

        public Insurance()
        {
            clients = new List<Person>();

            reasonsSum = new Dictionary<string, decimal>
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
            if (ClientIsPresent(client) == false)
            {
                clients.Add(client);
            }
        }

        public void BillPayment( ref CashAccount account)//?
        {
            currentAccount = account;
            Validation();
            if (validReason && validFulName && validSum)
            {
                account.Status = "payment";
            }
        }

        bool ClientIsPresent(Person client)
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

        void Validation()
        {
            ReasonValidation();
            FullNameValidation();
        }

        void SumValidation(decimal bill, decimal limit)
        {
            if (bill <= limit)
            {
                validSum = true;
            }
            else
            {
                validSum = false;
            }
        }

        void ReasonValidation()
        {
            validReason = false;
            foreach (var reasonSum in reasonsSum)
            {
                if (reasonSum.Key == currentAccount.Reason)
                {
                    SumValidation(currentAccount.Sum, reasonSum.Value);
                    validReason = true;
                    break;
                }
            }
        }

        void FullNameValidation()
        {
            validFulName = false;
            foreach (var client in clients)
            {
                if (client.FullName == currentAccount.ClientFullName)
                {
                    validFulName = true;
                    break;
                }
            }
        }
    }
}
