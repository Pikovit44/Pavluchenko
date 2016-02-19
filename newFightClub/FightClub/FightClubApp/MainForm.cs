using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubApp.FightersClasses;
using System.Windows.Forms;

namespace FightClubApp
{
    public interface IMainForm
    {

        int Round { get; }
        string PlayerName { set; }
        int PlayerHp { set; }
        string BotName { set; }
        int BotHp { set; }
        PartOfBody Hit { get; }
        PartOfBody Block { get; }
        string Log { set; }
        event EventHandler FightClick;
    }

    public partial class MainForm : Form, IMainForm
    {
        
        Presenter presenter = null;
        public event EventHandler FightClick;
        PartOfBody hit;
        PartOfBody block;
        int round = 1;
        
        public MainForm()
        {
            InitializeComponent();
            presenter = new Presenter(this);
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

        private void butFight_Click(object sender, EventArgs e)
        {
            roundLb.Text = Log = "Раунд " + round;
            
            if (attHeadRb.Checked) { block = PartOfBody.head; }
            if (attTorsRb.Checked) { block = PartOfBody.tors; }
            if (attLegsRb.Checked) { block = PartOfBody.legs; }
            if (protHeadRb.Checked) { hit = PartOfBody.head; }
            if (protTorsRb.Checked) { hit = PartOfBody.tors; }
            if (protLegsRb.Checked) { hit = PartOfBody.legs; }
            if (attHeadRb.Checked == attTorsRb.Checked == attLegsRb.Checked && protHeadRb.Checked == protTorsRb.Checked == protLegsRb.Checked)
            {
                if (playerHpPrgrBar.Value != 0 && botHpPrgrBar.Value != 0)
                {
                    if (FightClick != null) { FightClick(this, EventArgs.Empty); }
                }
            }
            round++;
        }

        public string Log
        {
            set { logFld.Text += value + Environment.NewLine; }
        }

        private void endFightButt_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
