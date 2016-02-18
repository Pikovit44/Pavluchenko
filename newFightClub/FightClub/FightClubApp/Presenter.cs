using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using System.Threading.Tasks;

namespace FightClubApp
{
    public class Presenter
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        private readonly IMainForm view;
        private readonly ITextInfo textInfo;
        private readonly IGameController controller;

        public Presenter(IMainForm view)
        {
            Player player = new Player();
            Bot bot = new Bot();
            this.controller = new GameController(player, bot);
            this.textInfo = new TextInfo(player, bot, view);
            this.player = player;
            this.bot = bot;
            this.view = view;


            view.FightClick += onFightClick;
            View();
            textInfo.SetMessage();
        }

        public void SetupPosition()
        {
            player.HitPart = view.Hit;
            player.BlockPart = view.Block;
        }
        
        public void View()
        {
            view.PlayerHp = player.HP;
            view.BotName = bot.Name;
            view.BotHp = bot.HP;
        }

        public void onFightClick(object sender, EventArgs e)
        {
            SetupPosition();
            controller.Fight();
            View();
        }
    }
    
}
