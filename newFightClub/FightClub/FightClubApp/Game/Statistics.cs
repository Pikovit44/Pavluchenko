using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FightClubApp.Inerfaces;
using System.Windows.Forms;
using System.Threading.Tasks;
using FightClubApp.FightersClasses;

namespace FightClubApp
{
    
    class Statistics: IStatistics
    {
        int hitLegs = 0;
        int hitTors = 0;
        int hitHead = 0;
        int blockLegs = 0;
        int blockTors = 0;
        int blockHead = 0;
        private readonly IMainForm view;

        public Statistics(IMainForm view)
        {
            this.view = view;
            view.FightClick += onFightClick;
            view.StatisticsClick += onStatisticsClick;
            view.NextFightClick += onNextFightClick;
        }
        public int HitLegs
        {
            get { return hitLegs; }
        }
        public int HitTors
        {
            get { return hitTors; }
        }
        public int HitHead
        {
            get { return hitHead; }
        }
        public int BlockLegs
        {
            get { return blockLegs; }
        }
        public int BlockTors
        {
            get { return blockTors; }
        }
        public int BlockHead
        {
            get { return blockHead; }
        }
        public void ShowInfo()
        {
            int round = hitHead + hitLegs + hitTors;

            string info = "Количество проведенных раундов: " + round + Environment.NewLine + Environment.NewLine + "Статистика ударов игрока: " + Environment.NewLine
                           + "В голову: " + hitHead + Environment.NewLine + "В корпус: " + hitTors + Environment.NewLine + "В ноги: "
                           + hitLegs + Environment.NewLine + Environment.NewLine
                           + "Статистика блоков игрока: " + Environment.NewLine
                           + "Голова: " + blockHead + Environment.NewLine + "Корпус: " + blockTors + Environment.NewLine + "Ноги: "
                           + blockLegs + Environment.NewLine;

            MessageBox.Show(info, "Итоги боя", MessageBoxButtons.OK, MessageBoxIcon.Information); // срабатывает 2 раза
        }

        public void FightStatis()
        {
            switch (view.Block)
            {
                case PartOfBody.Unknown:
                    break;
                case PartOfBody.Head:
                    blockHead++;
                    break;
                case PartOfBody.Tors:
                    blockTors++;
                    break;
                case PartOfBody.Legs:
                    blockLegs++;
                    break;
                default:
                    break;
            }
            switch (view.Hit)
            {
                case PartOfBody.Unknown:
                    break;
                case PartOfBody.Head:
                    hitHead++;
                    break;
                case PartOfBody.Tors:
                    hitTors++;
                    break;
                case PartOfBody.Legs:
                    hitLegs++;
                    break;
                default:
                    break;
            }
        }
        private void onStatisticsClick(object sender, EventArgs e)
        {
            ShowInfo();
        }

        public void onFightClick(object sender, EventArgs e)
        {
            FightStatis();
        }

        public void onNextFightClick (object sender, EventArgs e)
        {
            hitLegs = hitTors = hitHead = blockLegs = blockTors = blockHead = 0;
        }


       
        
    }
}
