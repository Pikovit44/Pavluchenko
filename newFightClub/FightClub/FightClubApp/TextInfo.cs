using System;
using System.Collections.Generic;
using System.Linq;
using FightClubApp.FightersClasses;
using System.Windows.Forms;
using System.Text;
using FightClubApp.Inerfaces;
using System.Threading.Tasks;

namespace FightClubApp
{
    

    class TextInfo: ITextInfo
    {
        IStatistics statistics;
        IPlayer player;
        IBot bot;
        IMainForm view;

        public TextInfo(IPlayer player, IBot bot, IMainForm view, IStatistics statistics)
        {
            this.player = player;
            this.bot = bot;
            this.view = view;
            this.statistics = statistics;
        }

        public void SetMessage()
        {
            player.Wound += player_Wound;
            player.Block += player_Block;
            player.Death += player_Death;
            bot.Wound += player_Wound;
            bot.Block += player_Block;
            bot.Death += player_Death;
            view.EndRound += onEndRound;
        }

        public string PatrtToString(PartOfBody part)
        {
            string result = "";
            switch (part)
            {
                case PartOfBody.Unknown:
                    break;
                case PartOfBody.Head:
                    result = "голову";
                    break;
                case PartOfBody.Tors:
                    result = "корпус";
                    break;
                case PartOfBody.Legs:
                    result = "ноги";
                    break;
                default:
                    break;
            }
            return result;
        }

        public void WinnerName()
        {
            string info;

            if (player.HP == (int)Constant.DeathHP && bot.HP == (int)Constant.DeathHP)
            {
                view.Log = info = "Бой не выявил победителя. Пали оба бойца...";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);

            }
            else if (bot.HP == (int)Constant.DeathHP)
            {
                view.Log = info = "Игрок победил!";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
            }
            else
            {
                view.Log = info = "Победил Бот!";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
            }
        }


        private void player_Wound(object sender, MyEventArgs e)
        {
            view.Log =  e.Name + " неудачно защищал " + PatrtToString(e.Block) + " и получил удар в " 
                        + PatrtToString(e.Part) + ". " + e.Hp + " hp осталось.";
        }

        private void player_Block(object sender, MyEventArgs e)
        {
            view.Log = e.Name + " успешно защитил " + PatrtToString(e.Block) + ". Удар не прошел и у него по прежнему остается " + e.Hp + " hp.";
        }

        private void player_Death(object sender, MyEventArgs e)
        {
            view.Log = e.Name + " побежден, с " + e.Hp + " hp он больше не может сопротивляться.";

        }

        private void onEndRound(object sender, EventArgs e)
        {
            view.Log = "Схватка окончена.";
            WinnerName();
        }

    }
}
