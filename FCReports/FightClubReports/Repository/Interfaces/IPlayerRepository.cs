using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        List<Player> GetTopPlayers();
        List<Player> GetValidEmailPlayers();
        List<Player> GetPlayersByRegist();
        List<Player> GetListOfPlayersByLogin();
        List<Player> GetListOfPlayersByNumberOfGame();
    }
}
