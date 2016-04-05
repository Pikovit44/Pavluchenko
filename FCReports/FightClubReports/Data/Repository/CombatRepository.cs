using FightClubReports.Data;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class CombatRepository : BaseRepository<Combat>, ICombatRepository
    {

        public CombatRepository(Context db) : base(db)
        {
           
        }

        public IEnumerable<Combat> GetCombatsByPlayer(string login)
        {
            return db.Combat
                .Where(p => (p.Player1.Login == login) || (p.Player2.Login == login))
                .ToList();
        }

        public IEnumerable<Combat> GetCombatsByType()
        {
            return db.Combat
                .OrderBy(t => (!t.TypePVP))
                .ThenBy(tr => (tr.TypePVP))
                .ToList();
        }

        public IEnumerable<Combat> GetCombatsByDate()
        {
            return db.Combat
                .OrderBy(d => d.TimeOfStart)
                .ToList();
        }
    }
}
