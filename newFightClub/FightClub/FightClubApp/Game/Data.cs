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
        public string Name { get; set; }
        public int NumberOfFight { get; set; }
        public int NumberOfWin { get; set; }
        public int NumberOfTie { get; set; }
        public int NumberOfLoss { get; set; }

        public Data( string name, int fight, int win, int tie, int losse)
        {
            Name = name;
            NumberOfFight = fight;
            NumberOfWin = win;
            NumberOfTie = tie;
            NumberOfLoss = losse;
        }


    }
}
