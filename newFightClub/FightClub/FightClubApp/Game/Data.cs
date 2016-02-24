using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp.UI.Login;
using FightClubApp.FightersClasses;
using FightClubApp.Inerfaces;
using FightClubApp.Game.Inerfaces;

namespace FightClubApp.Game 
{
    public class Data : IData
    {
        private readonly IPlayer player;
        private readonly IMainForm view;
        private readonly IStatistics statistics;
        public string Name { get; set; }
        public int NumberOfFight { get; set; }
        public int NumberOfWin { get; set; }
        public int NumberOfTie { get; set; }
        public int NumberOfLoss { get; set; }

        public Data( IPlayer player, IMainForm view, IStatistics statistics)
        {
            this.player = player;
            this.view = view;
            this.statistics = statistics;
        }



    }
}
