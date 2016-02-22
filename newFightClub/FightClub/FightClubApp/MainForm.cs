using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp.FightersClasses;
using FightClubApp.Inerfaces;
using System.Media;
using System.Windows.Forms;

namespace FightClubApp
{

    public partial class MainForm : Form, IMainForm
    {
        
        Presenter presenter = null;
        Statistics statistics = null;
        public event EventHandler FightClick;
        public event EventHandler NextFightClick;
        public event EventHandler StatisticsClick;
        PartOfBody hit;
        PartOfBody block;
        int round = (int)Constant.firstRound;
        SoundPlayer music; // музыка заднего плана во время игры
        
        public MainForm()
        {
            InitializeComponent();
            music = new SoundPlayer(Properties.Resources.One_Republic_Everybody_Loves_Me_OST_Happily_Ever_A);

            music.PlayLooping();
            presenter = new Presenter(this);
            statistics = new Statistics(this);
        }
       
        public int Round
        {
            get { return round; }
        }
        
        public string PlayerName
        {
            set { namePlayerLb.Text = value; }
        }

        public int PlayerHp
        {
            get { return playerHpPrgrBar.Value; }
            set { playerHpPrgrBar.Value = value;}
        }

        public string BotName
        {
            set { nameBotLb.Text = value; }
        }

        public int BotHp
        {
            get { return botHpPrgrBar.Value; }
            set { botHpPrgrBar.Value = value;}
        }

        public PartOfBody Hit
        {
            get { return hit; }
        }
        public PartOfBody Block
        {
            get { return block; }
        }

        public string Log
        {
            set { logFld.Text += value + Environment.NewLine; }
        }

      

        public void WinnerName()
        {
            string info;

            if (playerHpPrgrBar.Value ==  (int)Constant.deathHP && botHpPrgrBar.Value == (int)Constant.deathHP)
            {
                Log = info = "Бой не выявил победителя. Пали оба бойца...";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
               
            }
            else if (botHpPrgrBar.Value == (int)Constant.deathHP)
            {
                Log = info = "Игрок победил!";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
            }
            else
            {
                Log = info = "Победил Бот!";
                MessageBox.Show(info, "Бой окончен", MessageBoxButtons.OK);
            }
        }

        private void butFight_Click(object sender, EventArgs e)
        {
            roundLb.Text = Log = "Раунд " + round;
            
            if (attHeadRb.Checked) { block = PartOfBody.head; }
            if (attTorsRb.Checked) { block = PartOfBody.tors; }
            if (attLegsRb.Checked) { block = PartOfBody.legs; }
            if (protHeadRb.Checked) { hit = PartOfBody.head; }
            if (protTorsRb.Checked) { hit = PartOfBody.tors; }
            if (protLegsRb.Checked) { hit = PartOfBody.legs; }
            {
                if (playerHpPrgrBar.Value != 0 && botHpPrgrBar.Value != 0)
                {
                    if (FightClick != null) { FightClick(this, EventArgs.Empty); }
                }
                if (playerHpPrgrBar.Value == (int)Constant.deathHP || botHpPrgrBar.Value == (int)Constant.deathHP) 
                {

                    fightButton.Enabled = false; // method
                    statistButton.Enabled = true;
                    nextFightButton.Enabled = true;
                    Log = "Схватка окончена.";
                    WinnerName();
                }
            }
            round++;
        }

        private void statistButton_Click(object sender, EventArgs e)
        {
            if (StatisticsClick != null) { StatisticsClick(this, EventArgs.Empty); }
        }

        private void nextFightButton_Click(object sender, EventArgs e)
        {
            logFld.SelectionStart = logFld.Text.Length; // установка курсора в конец лога?
            //logFld.Select(0, 0); 
            logFld.Text = "";
            playerHpPrgrBar.Value = botHpPrgrBar.Value = (int)Constant.startHP;
            round = (int)Constant.firstRound;
            roundLb.Text = "Раунд " + round;
            fightButton.Enabled = true;
            statistButton.Enabled = false;
            nextFightButton.Enabled = false;
            if (NextFightClick != null) { NextFightClick(this, EventArgs.Empty); }
        }

        private void endFightButt_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void musicCb_CheckedChanged(object sender, EventArgs e)
        {
            if (!musicCb.Checked)
            {
                music.Stop();
            }
            else
                music.PlayLooping();
        }

        //Как от этого избавиться? :(
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
