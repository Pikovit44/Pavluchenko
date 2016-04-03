using Enums;
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
using FightClubReports.Data;

namespace FightClubReports
{
    public partial class MainForm : Form, IView 
    {
        OutputInfoType outputInfo = OutputInfoType.Unknown;
        ViewInfoType infoType;
        string currentLogin = string.Empty;
        public event EventHandler OkClick;
        public MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
        
        public string CurrentLogin
        {
            get { return currentLogin; }
        }

        public OutputInfoType OutputInfo
        {
            get { return outputInfo; }
        }

        public ViewInfoType InfoType
        {
            get { return infoType; }
        }

        public object Table
        {
            set { table.DataSource = value; }
        }

        private void usersCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(ViewInfoType.User);
            infoType = ViewInfoType.User;
        }

        private void transactionsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(ViewInfoType.Transaction);
            infoType = ViewInfoType.Transaction;
        }

        private void CombatsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeVisible(ViewInfoType.Combat);
            infoType = ViewInfoType.Combat;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ChooseOutputInfo();
            if (SafeOk())
            {
                if (OkClick != null) { OkClick(this, EventArgs.Empty); }
            }
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
                else
                {
                    loginForTransactions.Visible = false;
                    loginForTransactionsLb.Visible = false;
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
                if (usersCb.Text == "Топ лучших") { outputInfo = OutputInfoType.UTop; }
                if (usersCb.Text == "По дате регистрации") { outputInfo = OutputInfoType.UDate; }
                if (usersCb.Text == "По алфавиту") { outputInfo = OutputInfoType.UAlphabet; }
                if (usersCb.Text == "По дате регистрации") { outputInfo = OutputInfoType.UDate; }
                if (usersCb.Text == "По количеству боев") { outputInfo = OutputInfoType.UNumOfComb; }
                if (usersCb.Text == "По количеству транзакций") { outputInfo = OutputInfoType.UNumOfTransact; }
                if (usersCb.Text == "По валидным Email") { outputInfo = OutputInfoType.UValidEmail; }
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
                        outputInfo = OutputInfoType.TLogin; currentLogin = loginForTransactions.Text;
                    }
                }
                if (combatsCb.Text == "По типу") { outputInfo = OutputInfoType.CType; }
                if (combatsCb.Text == "По логину игрока")
                {
                    if (loginForCombats.Text == "")
                    {
                    MessageBox.Show("Введите логин игрока в соответствующее поле", "Логин игрока не введен", MessageBoxButtons.OK);
                    loginForCombats.Focus();
                    }
                    else
                    {
                        outputInfo = OutputInfoType.CLogin; currentLogin = loginForCombats.Text;
                    }
                }
                
        }

        public bool SafeOk()
        {
            if (InfoType == ViewInfoType.Unknown)
            {
                MessageBox.Show("Выберете информацию для отображения", "Ни один вариант не выбран", MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
