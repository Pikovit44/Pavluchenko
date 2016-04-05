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
        ViewInfoType infoType = ViewInfoType.Player;
        string currentLogin = string.Empty;
        public event EventHandler playersOkClick;
        public event EventHandler transactionsOkClick;
        public event EventHandler combatsOkClick;
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

        public object PlayerTable
        {
            set { playersTable.DataSource = value; }
        }

        public object TransactionsTable
        {
            set { transactionsTable.DataSource = value; }
        }

        public object CombatsTable
        {
            set { combatsTable.DataSource = value; }
        }
        #endregion

        #region Events

       

        private void playersOk_Click(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Player;
            ChooseOutputInfo();
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }

        private void transactionsOk_Click(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Transaction;
            ChooseOutputInfo();
            if (transactionsOkClick != null) { transactionsOkClick(this, EventArgs.Empty); }
        }

        private void combatsOk_Click(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Combat;
            ChooseOutputInfo();
            if (combatsOkClick != null) { combatsOkClick(this, EventArgs.Empty); }
        }

        #endregion

        #region Methods

        private void ChooseOutputInfo()
        {
            switch (infoType)
            {
                case ViewInfoType.Player:
                    ChoosePlayersOuputInfo();
                    break;

                case ViewInfoType.Transaction:
                    ChooseTransactionsOuputInfo();
                    break;

                case ViewInfoType.Combat:
                    ChooseCombatsOutputInfo();
                    break;

                default:
                    break;
            }
        }

        private void ChoosePlayersOuputInfo()
        {
            
            if (topPlayers.Checked == true) { outputInfo = OutputInfoType.UTop; }
            if (playersByDate.Checked == true) { outputInfo = OutputInfoType.UDate; }
            if (playersByAlphabet.Checked == true) { outputInfo = OutputInfoType.UAlphabet; }
            if (playersByNumberOfCombats.Checked == true) { outputInfo = OutputInfoType.UNumOfComb; }
            if (playersByNumberOfTransactions.Checked == true) { outputInfo = OutputInfoType.UNumOfTransact; }
            if (playersByValidEmail.Checked == true) { outputInfo = OutputInfoType.UValidEmail; }
        }

        private void ChooseTransactionsOuputInfo()
        {
            if (transactionsBySum.Checked == true) { outputInfo = OutputInfoType.TSum; }
            if (transactionsByDate.Checked == true) { outputInfo = OutputInfoType.TDate; }
            if (transactionsByLogin.Checked == true)
            {
                if (loginForTransactions.Text == string.Empty) // safe ok?
                {
                    MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                    loginForTransactions.Focus();
                }
                else
                {
                    outputInfo = OutputInfoType.TLogin; currentLogin = loginForTransactions.Text;
                }
            }
        }

        private void ChooseCombatsOutputInfo()
        {
            if (combatsByType.Checked == true) { outputInfo = OutputInfoType.CType; }
            if (combatsByLogin.Checked == true)
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






        #endregion
    }
}

