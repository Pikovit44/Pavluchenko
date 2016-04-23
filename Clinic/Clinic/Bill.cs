using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class Bill : ICashAccount
    {
        bool status;

        public Bill(DateTime date, string clientFullName, string reason, decimal sum)
        {
            Date = date;
            ClientFullName = clientFullName;
            Reason = reason;
            Sum = sum;
        }


        public DateTime Date { get; private set; }

        public string ClientFullName { get; private set; }

        public string Reason { get; private set; }

        string shortfall;

        public string Status
        {
            get
            {
                if (status == true)
                {
                    return "paid";
                }
                else if (shortfall != string.Empty)
                {
                    return shortfall;
                }
                else
                {
                    return "not paid";
                }
            }
            set
            {
                if (value == "payment")
                {
                    status = true;
                }
                else
                {
                    shortfall = value;
                }
            }
        }

        public decimal Sum { get; private set; }
    }
}
