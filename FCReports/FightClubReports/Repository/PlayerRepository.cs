using FightClubReports.Data;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class PlayerRepository :BaseRepository<Player> , IPlayerRepository
    {

        public PlayerRepository()
        {
            this.db = new Context(); // сделать фассад 
        }

        public List<Player> GetListOfPlayersByLogin()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetListOfPlayersByNumberOfGame()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersByRegist()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetTopPlayers()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetValidEmailPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
