using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Interfaces
{
    public interface IView
    {
        OutputInfoType OutputInfo { get; }
        string Login { get; }
        event EventHandler Ok;
    }
}
