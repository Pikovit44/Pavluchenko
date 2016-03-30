using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface IFacadeRepository
    {
        IPlayerRepository Player { get; }
        ICombatRepository Combat { get; }
        ITransactionRepository Transaction { get; }
        void Dispose();
        void Save();

    }
}
