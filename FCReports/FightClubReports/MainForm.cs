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
    enum InfoType { User, Transaction, Combat }
     
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void usersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(InfoType.User);
        }

        private void transactionsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(InfoType.Transaction);
        }

        private void CombatsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(InfoType.Combat);
        }

        private void ChangeVisible(InfoType type)
        {
            switch (type)
            {
                case InfoType.User:
                    UserVisible(true);
                    break;
                case InfoType.Transaction:
                    TransactionVisible(true);
                    break;
                case InfoType.Combat:
                    CombatVisible(true);
                    break;
                default:
                    break;
            }
        }

        private void UserVisible(bool flag)//flag?
        {
            if (flag)
            {
                TransactionVisible(false);
                CombatVisible(false);
                if (usersCb.Text != "")
                {
                    ok.Focus();
                }
            }
            else
            {
                usersCb.Text = "";
            }
        }

        private void TransactionVisible( bool flag)
        {
            if (flag)
            {
                if (transactionsCb.Text != "")
                {
                    ok.Focus();
                }
                if (transactionsCb.Text == "По логину игрока")
                {
                    loginForTransactions.Visible = true;
                    loginForTransactionsLb.Visible = true;
                    loginForTransactions.Focus();
                }
                UserVisible(false);
                CombatVisible(false);
            }
            else
            {
                loginForTransactionsLb.Visible = false;
                loginForTransactions.Visible = false;
                transactionsCb.Text = "";
                loginForTransactions.Text = "";
            }
        } 

        private void CombatVisible(bool flag)
        {
            if (flag)
            {
                if (combatsCb.Text != "")
                {
                    ok.Focus();
                }

                if (combatsCb.Text == "По логину игрока")
                {
                    loginForCombats.Visible = true;
                    loginForCombatsLb.Visible = true;
                    loginForCombats.Focus();
                }
                UserVisible(false);
                TransactionVisible(false);
            }
            else
            {
                loginForCombats.Visible = false;
                loginForCombatsLb.Visible = false;
                combatsCb.Text = "";
                loginForCombats.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
