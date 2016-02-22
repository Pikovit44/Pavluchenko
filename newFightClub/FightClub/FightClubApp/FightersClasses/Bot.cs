using System;
using FightClubApp.Inerfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.FightersClasses
{
    

    class Bot : Player, IBot
    {
        Random rand = new Random();
        public Bot()
        {
            this.hp = 100;
            this.name = "Бот";
        }

        public PartOfBody BotBlock
        {
            get { return (PartOfBody)rand.Next(1, 4); }
        }
        public PartOfBody BotHit
        {
            get { return (PartOfBody)rand.Next(1, 4); }
        }
    }
}
