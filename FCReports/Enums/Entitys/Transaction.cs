﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Entitys
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Player Player { get; set; } //Id? 
        public decimal Sum { get; set; }
    }
}
