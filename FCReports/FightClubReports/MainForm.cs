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
using FightClubReports.Properties;
using FightClubReports.Data;

namespace FightClubReports
{
    public partial class MainForm : Form, IView 
    {
        OutputInfoType outputInfo = OutputInfoType.Unknown;
        ViewInfoType infoType;
        string currentLogin = string.Empty;
        public event EventHandler OkClick;
        public event EventHandler SaveClick;
        public MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        #region Properties
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
        #endregion

        #region Events
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

        private void saveChanges_Click(object sender, EventArgs e)
        {
            if(SaveClick != null) { SaveClick(this, EventArgs.Empty); }
        }

        private void сancelСhanges_Click(object sender, EventArgs e)
        {
            
                if (OkClick != null) { OkClick(this, EventArgs.Empty); }
            
        }

        #endregion

        #region Methods
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
                if (usersCb.Text != string.Empty)
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
                if (transactionsCb.Text != string.Empty)
                {
                    ok.Focus();
                }
                if (transactionsCb.Text == Resources.transactionsByLogin)
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
                transactionsCb.Text = string.Empty;
                loginForTransactions.Text = string.Empty;
            }
        } 

        private void CombatVisible(bool flag)
        {
            if (flag)
            {
                if (combatsCb.Text != string.Empty)
                {
                    ok.Focus();
                }

                if (combatsCb.Text == Resources.combatsByLogin)
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
                combatsCb.Text = string.Empty;
                loginForCombats.Text = string.Empty;
            }

        }
        
        private void ChooseOutputInfo()
        {
                if (usersCb.Text == Resources.topPlayers) { outputInfo = OutputInfoType.UTop; }
                if (usersCb.Text == Resources.playersByDate) { outputInfo = OutputInfoType.UDate; }
                if (usersCb.Text == Resources.playersByAlphabet) { outputInfo = OutputInfoType.UAlphabet; }
                if (usersCb.Text == Resources.playersByNumberOfCombats) { outputInfo = OutputInfoType.UNumOfComb; }
                if (usersCb.Text == Resources.playersByNumberOfTransactions) { outputInfo = OutputInfoType.UNumOfTransact; }
                if (usersCb.Text == Resources.playersByValidEmail) { outputInfo = OutputInfoType.UValidEmail; }
                if (transactionsCb.Text == Resources.transactionsBySum) { outputInfo = OutputInfoType.TSum; }
                if (transactionsCb.Text == Resources.transactionsByDate) { outputInfo = OutputInfoType.TDate; }
                if (transactionsCb.Text == Resources.transactionsByLogin)
                {
                    if (loginForTransactions.Text == string.Empty)
                    {
                        MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                        loginForTransactions.Focus();
                    }
                    else
                    {
                        outputInfo = OutputInfoType.TLogin; currentLogin = loginForTransactions.Text;
                    }
                }
                if (combatsCb.Text == Resources.combatsByType) { outputInfo = OutputInfoType.CType; }
                if (combatsCb.Text == Resources.combatsByLogin)
                {
                    if (loginForCombats.Text == string.Empty)
                    {
                    MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                    loginForCombats.Focus();
                    }
                    else
                    {
                        outputInfo = OutputInfoType.CLogin; currentLogin = loginForCombats.Text;
                    }
                }
                
        }

        private bool SafeOk()
        {
            if (InfoType == ViewInfoType.Unknown)
            {
                MessageBox.Show(Resources.chooseInfoForShow, Resources.noOneOptionIsNotSelected, MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
