﻿using Enums;
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
        ViewInfoType infoType = ViewInfoType.Unknown;
        string requiredLogin = string.Empty;
        public event EventHandler playersOkClick;
        public event EventHandler transactionsOkClick;
        public event EventHandler combatsOkClick;
        public event EventHandler playerSaveClick;
        public MainPresenter presenter;
        public Player selectedPlayer = new Player();

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
            playersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #region Properties

        public Player SelectedPlayer
        {
            get { return selectedPlayer; }
        } 

        public string RequiredLogin
        {
            get { return requiredLogin; }
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

        #region Players
        private void topPlayers_CheckedChanged(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Player;
            outputInfo = OutputInfoType.PTop;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }

        private void playersByValidEmail_CheckedChanged(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Player;
            outputInfo = OutputInfoType.PValidEmail;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }

        private void playersByNumberOfCombats_CheckedChanged(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Player;
            outputInfo = OutputInfoType.PNumOfComb;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }

        private void playersByAlphabet_CheckedChanged(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Player;
            outputInfo = OutputInfoType.PAlphabet;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }

        private void playersByDate_CheckedChanged(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Player;
            outputInfo = OutputInfoType.PDate;
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }

        private void playersByLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (playersByLogin.Checked == true)
            {
                loginForPlayers.Visible = true;
                playersOk.Visible = true;
                loginForPlayers.Focus();
            }
            else
            {
                loginForPlayers.Visible = false;
                playersOk.Visible = false;
            }

        }

        private void playersOk_Click(object sender, EventArgs e)
        {
            if (loginForPlayers.Text == string.Empty)
            {
                MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                loginForTransactions.Focus();
            }
            else
            {
                outputInfo = OutputInfoType.PLogin; selectedPlayer.Login = loginForPlayers.Text;
                if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
            }
            if (playersOkClick != null) { playersOkClick(this, EventArgs.Empty); }
        }
        #endregion

        #region Transactions
        private void transactionsOk_Click(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Transaction;
            if (transactionsOkClick != null) { transactionsOkClick(this, EventArgs.Empty); }
        }

        private void combatsOk_Click(object sender, EventArgs e)
        {
            infoType = ViewInfoType.Combat;
            if (combatsOkClick != null) { combatsOkClick(this, EventArgs.Empty); }
        }



        private void transactionsByLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (transactionsByLogin.Checked == true)
            {
                loginForTransactions.Visible = loginForTransactionsLb.Visible = true;
                loginForTransactions.Focus();
            }
            else
            {
                loginForTransactions.Visible = loginForTransactionsLb.Visible = false;
            }
        }
        #endregion

       

        private void combatsByLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (combatsByLogin.Checked == true)
            {
                loginForCombats.Visible = loginForCombatsLb.Visible = true;
                loginForCombats.Focus();
            }
            else
            {
                loginForCombatsLb.Visible = loginForCombats.Visible = false;
            }

        }


        #endregion

        #region Methods
        

        private void ChoosePlayersOuputInfo()
        {
            
                if (loginForPlayers.Text == string.Empty) 
                {
                    MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                    loginForTransactions.Focus();
                }
                else
                {
                    outputInfo = OutputInfoType.PLogin; requiredLogin = loginForPlayers.Text;
                }
            
        }

        private void ChooseTransactionsOuputInfo()
        {
            if (transactionsBySum.Checked == true) { outputInfo = OutputInfoType.TSum; }
            if (transactionsByDate.Checked == true) { outputInfo = OutputInfoType.TDate; }
            if (transactionsByLogin.Checked == true)
            {
                if (loginForTransactions.Text == string.Empty) 
                {
                    MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                    loginForTransactions.Focus();
                }
                else
                {
                    outputInfo = OutputInfoType.TLogin; requiredLogin = loginForTransactions.Text;
                }
            }
        }

        private void ChooseCombatsOutputInfo()
        {
            if (combatsByType.Checked == true) { outputInfo = OutputInfoType.CType; }
            if (combatsByDate.Checked == true) { outputInfo = OutputInfoType.CDate; }
            if (combatsByLogin.Checked == true)
            {
                if (loginForCombats.Text == string.Empty)
                {
                    MessageBox.Show(Resources.enterLoginInField, Resources.loginIsNotEntered, MessageBoxButtons.OK);
                    loginForCombats.Focus();
                }
                else
                {
                    outputInfo = OutputInfoType.CLogin; requiredLogin = loginForCombats.Text;
                }
            }
        }

        #endregion

       

        private void playersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPlayer.Id = (int)playersTable[0, playersTable.CurrentCellAddress.Y].Value;
            loginEditTb.Text = playersTable[1, playersTable.CurrentCellAddress.Y].Value.ToString();
            passwordEditTb.Text = playersTable[2, playersTable.CurrentCellAddress.Y].Value.ToString();

            var emailVal = playersTable[3, playersTable.CurrentCellAddress.Y].Value;
            if ( null != emailVal)
            {
                emailEditTb.Text = selectedPlayer.EMail = emailVal.ToString();
            }
            else
            {
                selectedPlayer.EMail = string.Empty;
                emailEditTb.Text = Resources.notSpecified;
            }
        }

        private void SavePlayerChanges()
        {

            selectedPlayer.Login = loginEditTb.Text;
            selectedPlayer.Password = passwordEditTb.Text;
            selectedPlayer.EMail = emailEditTb.Text;
        }

        private void save_Click(object sender, EventArgs e)
        {
            SavePlayerChanges();
            MessageBox.Show(Resources.successfulSaving, Resources.saveChanges, MessageBoxButtons.OK);
            if (playerSaveClick != null) {playerSaveClick(this, EventArgs.Empty);}
        }
        
    }
}

