using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using FightClubApp.Game.Inerfaces;
using FightClubApp.Inerfaces;
using FightClubApp.Game;
using System.Threading.Tasks;

namespace FightClubApp
{  
    public class GameController: IGameController
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        private IData data;
        //private readonly IData data;
        //private readonly ITextInfo textInfo;


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
            player.HP = bot.HP = (int)Constant.StartHP; 
        }
        
        public void setData(int fight, int win, int tie, int losse)
        {
            this.data = new Data(player.Name, fight, win, tie, losse);
            //SaveData();
        }

        
    }
}
