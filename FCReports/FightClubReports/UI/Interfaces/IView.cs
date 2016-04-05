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
        ViewInfoType InfoType {  get; }
        string CurrentLogin { get; }
        event EventHandler playersOkClick;
        event EventHandler transactionsOkClick;
        event EventHandler combatsOkClick;
        object PlayerTable {  set; }
        object TransactionsTable { set; }
        object CombatsTable { set; }
    }
}
