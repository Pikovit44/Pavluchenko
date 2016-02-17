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
        int round;
        
        public MainForm()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        public int Round
        {
            get { return round; }
        }
        // Player Name 
        public string PlayerName
        {
            set { nameBoxLb.Text = value; }
        }

        public int PlayerHp
        {
            get { return playerHpPrgrBar.Value; }
            set { playerHpPrgrBar.Value = value;}
        }

        public string BotName
        {
            set { botNameLb.Text = value; }
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
            set { LogFld.Text += value + Environment.NewLine; }
        }

        private void fldNameBox_TextChanged(object sender, EventArgs e)
        {
            if (nameBoxLb.Text != "")
            {
                fightButton.Enabled = true;
            }
            lbPlayerName.Text = nameBoxLb.Text;
        }

        private void butFight_Click(object sender, EventArgs e)
        {
            if (attHeadRb.Checked) { hit = PartOfBody.head; }
            if (attTorsRb.Checked) { hit = PartOfBody.tors; }
            if (attLegsRb.Checked) { hit = PartOfBody.legs; }
            if (protHeadRb.Checked) { block = PartOfBody.head; }
            if (protTorsRb.Checked) { block = PartOfBody.tors; }
            if (protLegsRb.Checked) { block = PartOfBody.legs; }

            if (playerHpPrgrBar.Value != 0 && botHpPrgrBar.Value != 0)
            {
                FightClick(this, EventArgs.Empty);
                //presenter.onFightClick(this, EventArgs.Empty);
                
            }

            attHeadRb.Checked = attTorsRb.Checked = attLegsRb.Checked = protHeadRb.Checked = protTorsRb.Checked = protLegsRb.Checked = false;

            Log = lbRound.Text = "Раунд" + round;
            round++;
            
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_FightClick(object sender, EventArgs e)
        {

        }
    }
}
