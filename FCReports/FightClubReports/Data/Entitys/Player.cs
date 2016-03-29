﻿using FightClubReports.Data.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightClubReports
{
    public class Player
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }        
        public bool IsEmaillValid { get; set; }
        public DateTime DateOfRegistr { get; set; }
        public List<Combat> GameData { get; set; }
        public Statistics Statistics { get; set; }
    }
}