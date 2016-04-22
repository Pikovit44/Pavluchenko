using Clinic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    public class CashAccount : ICashAccount
    {
        bool status;
        Discription discription;

        public DateTime Date { get; private set; }

        public string Recipient { get; private set; }

        public string Sender { get; private set; }

        public string Status
        {
            get
            {
                if (status == true)
                {
                    return "paid";
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

            }
        }

        public decimal Sum { get; private set; }

        public Discription Discription
        { get { return discription; }  }
    }
}
