using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface ICombatRepository : IRepository<Combat>
    {
        List<Combat> GetCombatsByType(string type);
        List<Combat> GetCombatsByPlayer(string login);

    }
}
