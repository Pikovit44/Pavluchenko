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

        public DbSet<Player> Player { get; set; }
        public DbSet<Combat> Combat { get; set; }
        public DbSet<RoundLog> RoundLog { get; set; } //?
        public DbSet<Transaction> Transaction { get; set; }
    }
}
