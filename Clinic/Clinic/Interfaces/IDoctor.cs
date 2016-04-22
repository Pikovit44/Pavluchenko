using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Interfaces
{
    public interface IDoctor
    {
        int cabinet { get;}
        bool licence { get; }
        Treatment Diagnosise();
    }
}
