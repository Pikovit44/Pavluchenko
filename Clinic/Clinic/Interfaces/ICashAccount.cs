using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public interface ICashAccount
    {
        string Sender { get; }
        string Recipient { get; }
        decimal Sum { get; }
        Discription Discription { get; }
        string Status { get; }
        DateTime Date { get; }
    }
}
