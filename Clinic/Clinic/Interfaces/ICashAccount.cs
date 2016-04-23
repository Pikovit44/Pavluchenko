using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public interface ICashAccount
    {
        decimal Sum { get; }
        string ClientFullName { get; }
        string Reason { get; }
        string Status { get; }
        DateTime Date { get; }
    }
}
