﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface IPlayerRepository : IRepository<Player>
    {
        IEnumerable<Player> GetTopPlayers();
        IEnumerable<Player> GetValidEmailPlayers();
        IEnumerable<Player> GetPlayersByRegist();
        IEnumerable<Player> GetListOfPlayersByLogin();
        IEnumerable<Player> GetPlayersByNumberOfGame();
    }
}
