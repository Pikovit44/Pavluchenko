using System;
using System.Collections.Generic;

namespace FightClubReports
{
    public class Combat
    {
        DateTime timeOfCombat; 
        string type; // pvp or pve 
        List<RoundLog> log;
        Player player1;
        Player player2;
        bool winnerIsExist;
        Player winner;
    }
}