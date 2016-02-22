using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using FightClubApp.Inerfaces;
using System.Threading.Tasks;

namespace FightClubApp
{  
    public class GameController: IGameController
    {
        private readonly IPlayer player;
        private readonly IBot bot;

        public GameController(IPlayer player, IBot bot)
        {
            this.player = player;
            this.bot = bot;
        }
        public void Fight()
        {
            player.GetHit(bot.BotHit);
            player.SetBlock(player.BlockPart);
            bot.SetBlock(bot.BotBlock);
            bot.GetHit(player.HitPart);
        }
        public void SetHp()
        {
            player.HP = bot.HP = 100; // constant
        }

    }
}
