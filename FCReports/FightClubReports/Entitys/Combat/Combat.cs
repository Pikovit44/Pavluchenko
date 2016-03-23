﻿using System;
using System.Collections.Generic;

namespace FightClubReports
{
    public class Combat
    {
        public int Id { get; set; }
        public DateTime TimeOfStartCombat { get; set; }
        public string Type { get; set; } // pvp or pve 
        public List<RoundLog> Log { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public bool WinnerIsExist { get; set; }
        public Player Winner { get; set; }
    }
}