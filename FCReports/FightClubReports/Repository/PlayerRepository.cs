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
        public PlayerRepository()
        {
            this.db = new Context(); // сделать фассад 
        }

        public IEnumerable<Player> GetListOfPlayersByLogin()
        {
            return db.Player
                .OrderBy(l => l.Login)
                .ToList();
        }

        public IEnumerable<Player> GetPlayersByNumberOfGame()
        {
            return db.Player
                .OrderByDescending(s => s.Statistics.Combats);
        }

        public IEnumerable<Player> GetPlayersByRegist()
        {
            return db.Player
               .OrderBy(t => t.DateOfRegistr);
        }

        public IEnumerable<Player> GetTopPlayers()
        {
            return db.Player
                .OrderByDescending(w => w.Statistics.Wins)
                .ThenByDescending(d => d.Statistics.Draws);
        }

        public IEnumerable<Player> GetValidEmailPlayers()
        {
            return db.Player
               .Where(e => e.IsEmaillValid == true);
        }
    }
}
