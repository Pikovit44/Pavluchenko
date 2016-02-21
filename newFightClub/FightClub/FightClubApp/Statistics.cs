using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using FightClubApp.FightersClasses;

namespace FightClubApp
{
    public interface IStatistics
    {
        int HitLegs { get; set; }
        int HitTors { get; set; }
        int HitHead { get; set; }
        int BlockLegs { get; set; }
        int BlockTors { get; set; }
        int BlockHead { get; set; }

    }
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
        }

        private void onStatisticsClick(object sender, EventArgs e)
        {
            ShowInfo();
        }

        public void onFightClick(object sender, EventArgs e)
        {
            FightStatis();
        }

        public void ShowInfo()
        {
            int round = hitHead + hitLegs + hitTors; 
            string info = "Количество проведенных раундов: " + round + Environment.NewLine + Environment.NewLine + "Статистика ударов игрока: " + Environment.NewLine
                           + "В голову: " + hitHead + Environment.NewLine + "В корпус: " + hitTors + Environment.NewLine + "В ноги: " 
                           + hitLegs + Environment.NewLine + Environment.NewLine 
                           + "Статистика блоков игрока: " + Environment.NewLine
                           +  "Голова: " + blockHead + Environment.NewLine + "Корпус: " + blockTors + Environment.NewLine + "Ноги: "
                           + blockLegs + Environment.NewLine;

            MessageBox.Show(info, "Итоги боя", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //maybe without set
        public int HitLegs
        {
            get
            { return hitLegs; }
            set
            { hitLegs = value; }
        }
        public int HitTors
        {
            get { return hitTors;}
            set { hitTors = value;}
        }
        public int HitHead
        {
            get { return hitHead;}
            set { hitHead = value;}
        }
        public int BlockLegs
        {
            get {return blockLegs;}
            set {blockLegs = value;}
        }
        public int BlockTors
        {
            get { return blockTors;}

            set {blockTors = value;}
        }
        public int BlockHead
        {
            get { return blockHead;}

            set { blockHead = value;}
        }

        public void FightStatis ()
        {
            switch (view.Block)
            {
                case PartOfBody.unknown:
                    break;
                case PartOfBody.head:
                    blockHead++;
                    break;
                case PartOfBody.tors:
                    blockTors++;
                    break;
                case PartOfBody.legs:
                    blockLegs++;
                    break;
                default:
                    break;
            }
            switch (view.Hit)
            {
                case PartOfBody.unknown:
                    break;
                case PartOfBody.head:
                    hitHead++;
                    break;
                case PartOfBody.tors:
                    hitTors++;
                    break;
                case PartOfBody.legs:
                    hitLegs++;
                    break;
                default:
                    break;
            }
        }
        
    }
}
