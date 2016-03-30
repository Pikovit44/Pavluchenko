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
                .Where(p => (p.Player1.Login == login) || (p.Player2.Login == login));
        }

        public IEnumerable<Combat> GetCombatsByType(string type)
        {
            return db.Combat
                .Where(t => (t.Type == type));
        }
    }
}
