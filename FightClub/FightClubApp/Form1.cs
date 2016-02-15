using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int round = 1;
        
        Fighter Player = new Fighter();
        Fighter Bot = new Fighter();
        
        Random rand = new Random();



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttFight_Click(object sender, EventArgs e)
        {
            Bot.Name = "Bot";
            Log.Text = "";
            Log.Text += "Раунд" + round + Environment.NewLine;
            lbRound.Text = "Раунд " + round;

            //Проверяем атаку игрока, сделать события?
            if (attHead.Checked)
            {
                Player.GetHit(PartOfBody.head);
                Log.Text += Player.Name + " пытается нанести удар в голову";
            }
            else if (attTors.Checked)
            {
                Player.GetHit(PartOfBody.torso);
                Log.Text += Player.Name + " пытается нанести удар в корпус";
            }
            else
            {
                Player.GetHit(PartOfBody.legs);
                Log.Text += Player.Name + " пытается нанести удар в ноги";
            }

            //Сравниваем с защитой бота
            switch (rand.Next(1, 3))
            {
                case 1:
                    Bot.SetBlock(PartOfBody.head);
                    break;

                case 2:
                    Bot.SetBlock(PartOfBody.torso);
                    break;
                case 3:
                    Bot.SetBlock(PartOfBody.legs);
                    break;

                default:
                    break;
            }

            //Результат атаки игрока
            Log.Text +=  Fighter.BattleResult(ref Player, ref Bot);

            //Проверяем защиту
            if (protHead.Checked)
            {
                Player.SetBlock(PartOfBody.head);
            }
            else if (protTors.Checked)
            {
                Player.SetBlock(PartOfBody.torso);
            }
            else
            {
                Player.SetBlock(PartOfBody.legs);
            }

            //Сделать метод
            //Проверяем атаку бота
            switch (rand.Next(1,3))
            {
                case 1:
                    Bot.GetHit(PartOfBody.head);
                    Log.Text += Bot.Name + " пытается нанести удар в голову";
                    break;

                case 2:
                    Bot.GetHit(PartOfBody.torso);
                    Log.Text += Bot.Name + " пытается нанести удар в корпус";
                    break;
                case 3:
                    Bot.GetHit(PartOfBody.legs);
                    Log.Text += Bot.Name + " пытается нанести удар в ноги";
                    break;

                default:
                    break;
            }

            //Результат атаки бота
            Log.Text += Environment.NewLine + Fighter.BattleResult(ref Bot, ref Player);

            progrPlayer.Value = Player.HP;
            progrBot.Value = Bot.HP;

            if (Player.HP <= 0 || Bot.HP <= 0)
            {
                if (Bot.HP <= 0)
                {
                    MessageBox.Show(Player.Name + " победил!" );
                }
                else
                {
                    MessageBox.Show(Bot.Name + " победил!");
                }
            }

            round++;
            
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
