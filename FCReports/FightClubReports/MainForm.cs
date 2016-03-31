using FightClubReports.Interfaces;
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
    public enum ViewInfoType { User, Transaction, Combat }
    public enum OutputInfoType { Unknown, UTop, UDate, UAlphabet, UNumOfComb, UNumOfTransact, TSum, TDate, TLogin, CType, CLogin };


     
    public partial class MainForm : Form, IView 
    {
        OutputInfoType outputInfo = OutputInfoType.Unknown;
        string login = string.Empty;
        public event EventHandler Ok;

        public MainForm()
        {
            InitializeComponent();
        }
        
        public string Login
        {
            get { return login; }
        }

        public OutputInfoType OutputInfo
        {
            get { return outputInfo; }
        } 

        private void usersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(ViewInfoType.User);
        }

        private void transactionsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(ViewInfoType.Transaction);
        }

        private void CombatsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(ViewInfoType.Combat);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ChooseOutputInfo();
            if (Ok != null) { Ok(this, EventArgs.Empty); }
        }


        private void ChangeVisible(ViewInfoType type)
        {
            switch (type)
            {
                case ViewInfoType.User:
                    UserVisible(true);
                    break;
                case ViewInfoType.Transaction:
                    TransactionVisible(true);
                    break;
                case ViewInfoType.Combat:
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
                else
                {
                    loginForCombats.Visible = false;
                    loginForCombatsLb.Visible = false;
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

        private void ChooseOutputInfo()
        {
            if (outputInfo != OutputInfoType.Unknown)
            {
                if (usersCb.Text == "Топ лучших") { outputInfo = OutputInfoType.UTop; }
                if (usersCb.Text == "По дате регистрации") { outputInfo = OutputInfoType.UDate; }
                if (usersCb.Text == "По алфавиту") { outputInfo = OutputInfoType.UAlphabet; }
                if (usersCb.Text == "По дате регистрации") { outputInfo = OutputInfoType.UDate; }
                if (usersCb.Text == "По количеству боев") { outputInfo = OutputInfoType.UNumOfComb; }
                if (usersCb.Text == "По количеству транзакций") { outputInfo = OutputInfoType.UNumOfTransact; }
                if (transactionsCb.Text == "По сумме") { outputInfo = OutputInfoType.TSum; }
                if (transactionsCb.Text == "По дате") { outputInfo = OutputInfoType.TDate; }
                if (transactionsCb.Text == "По логину игрока")
                {
                    if (loginForTransactions.Text == "")
                    {
                        MessageBox.Show("Введите логин игрока в соответствующее поле", "Логин игрока не введен", MessageBoxButtons.OK);
                        loginForTransactions.Focus();
                    }
                    else
                    {
                        outputInfo = OutputInfoType.TLogin; login = loginForTransactions.Text;
                    }
                }
                if (combatsCb.Text == "По типу") { outputInfo = OutputInfoType.CType; }
                if (combatsCb.Text == "По логину игрока")
                {
                    MessageBox.Show("Введите логин игрока в соответствующее поле", "Логин игрока не введен", MessageBoxButtons.OK);
                    loginForCombats.Focus();
                }
                else
                {
                    outputInfo = OutputInfoType.CLogin; login = loginForCombats.Text;
                }
            }
            else
            {
                MessageBox.Show("Выберете информацию для отображения", "Ни один вариант не выбран", MessageBoxButtons.OK);
            }
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
