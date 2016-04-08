using FightClubReports.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Data
{
    public class Context: DbContext 
        
    {
        public Context():base("name=DBContextModel")
        { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Combat> Combats { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<RoundLog> RoundLogs { get; set; } 
        
    }
}
