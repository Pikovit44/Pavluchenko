using FightClubReports.Data;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class PlayerRepository :BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository( Context db) : base(db)
        {
           
        }

        public IEnumerable<Player> GetPlayersByLogin()
        {
            return db.Player
                .OrderBy(l => l.Login)
                .ToList();
        }

        public IEnumerable<Player> GetPlayerByLogin(string login)
        {
            return db.Player
                .Where(l => l.Login == login)
                .ToList();
        }

        public IEnumerable<Player> GetPlayersByNumberOfGame()
        {
            return db.Player
                .OrderByDescending(s => s.Statistics.Combats)
                .ToList();
        }

        public IEnumerable<Player> GetPlayersByNumberOfTransactions()
        {
            return db.Player
                .Where(t => t.Transactions != null) //?
                .OrderByDescending(tr => tr.Transactions.Count)
                .ToList();
        }

        public IEnumerable<Player> GetPlayersByRegist()
        {
            return db.Player
               .OrderBy(t => t.DateOfRegistr)
               .ToList();
        }

        public IEnumerable<Player> GetTopPlayers()
        {
            return db.Player
                .OrderByDescending(w => w.Statistics.Wins)
                .ThenByDescending(d => d.Statistics.Draws)
                .ToList();
        }

        public IEnumerable<Player> GetValidEmailPlayers()
        {
            return db.Player
               .Where(e => e.IsEmaillValid == true)
               .ToList();
        }
    }
}
