using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.FightersClasses;
using FightClubApp.Inerfaces;
using System.Threading.Tasks;

namespace FightClubApp
{
    public enum PartOfBody
    { unknown, head, tors, legs }

    public class Presenter
    {
        private readonly IPlayer player;
        private readonly IBot bot;
        private readonly IMainForm view;
        private readonly ITextInfo textInfo;
        private readonly IGameController controller;
        private readonly IStatistics statistics;

        public Presenter(IMainForm view)
        {

            Player player = new Player();
            Bot bot = new Bot();
            this.controller = new GameController(player, bot);
            this.textInfo = new TextInfo(player, bot, view, statistics);
            this.statistics = new Statistics(view);
            this.player = player;
            this.bot = bot;
            this.view = view;

            
            view.NextFightClick += onNextFightClick;
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

        public void onNextFightClick (object sender, EventArgs e)
        {
            controller.SetHp();
        }

        }

    }
    

