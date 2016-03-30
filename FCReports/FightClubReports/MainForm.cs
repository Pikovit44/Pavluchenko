using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubReports
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginForCombatsLb.Visible = false;
            loginForCombats.Visible = false;
            loginForTransactionsLb.Visible = false;
            loginForTransactions.Visible = false;
            combatsCb.Text = "";
            transactionsCb.Text = "";
            ok.Focus();
        }

        private void transactionsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginForCombatsLb.Visible = false;
            loginForCombats.Visible = false;
            combatsCb.Text = "";
            usersCb.Text = "";

            ok.Focus();

            if (transactionsCb.Text == "По логину игрока")
            {
                loginForTransactions.Visible = true;
                loginForTransactionsLb.Visible = true;
                loginForTransactions.Focus();
            }
        }

        private void CombatsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginForTransactionsLb.Visible = false;
            loginForTransactions.Visible = false;
            transactionsCb.Text = "";
            usersCb.Text = "";
            ok.Focus();

            if (combatsCb.Text == "По логину игрока")
            {
                loginForCombats.Visible = true;
                loginForCombatsLb.Visible = true;
                if (loginForCombats.Text != "")
                {
                    ok.Focus();
                }
                loginForCombats.Focus();
                
            }

        }
    }
}
