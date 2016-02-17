using System;
using System.Collections.Generic;
using System.Linq;
using FightClubApp.FightersClasses;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp
{
    public interface ITextInfo
    {
        void SetMessage();
    }

    class TextInfo: ITextInfo
    {
        IPlayer player;
        IBot bot;
        IMainForm view;

        public TextInfo(IPlayer player, IBot bot, IMainForm view)
        {
            this.player = player;
            this.bot = bot;
            this.view = view;
        }

        public void SetMessage()
        {
            player.Wound += player_Wound;
            player.Block += player_Block;
            player.Death += player_Death;
            bot.Wound += player_Wound;
            bot.Block += player_Block;
            bot.Death += player_Death;
        }

        public static string PatrtToString(PartOfBody part)
        {
            string result = "";
            switch (part)
            {
                case PartOfBody.unknown:
                    break;
                case PartOfBody.head:
                    result = "голову";
                    break;
                case PartOfBody.tors:
                    result = "корпус";
                    break;
                case PartOfBody.legs:
                    result = "ноги";
                    break;
                default:
                    break;
            }
            return result;
        }

        private void player_Wound(object sender, MyEventArgs e)
        {
            view.Log =  e.Name + " неудачно защищал " + PatrtToString(e.Block) + " и получил удар в " 
                        + PatrtToString(e.Part) + ". " + e.Hp + " hp осталось.";
        }

        private void player_Block(object sender, MyEventArgs e)
        {
            view.Log = e.Name + " успешно защищтил " + PatrtToString(e.Block) + ". Удар не прошел и e него по прежнему остается " + e.Hp + "hp.";
        }

        private void player_Death(object sender, MyEventArgs e)
        {
            view.Log = e.Name + " побежден, с " + e.Hp + " hp " + "он больше не может сопротивляться.";
        }


    }
}
