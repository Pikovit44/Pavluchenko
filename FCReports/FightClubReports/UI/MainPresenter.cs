﻿using FightClubReports.Data;
using FightClubReports.Entitys;
using FightClubReports.Interfaces;
using FightClubReports.Properties;
using FightClubReports.Repository;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports
{
    public class MainPresenter
    {
        private readonly IView view;
        private readonly ServiceRepository service;
        private List<Player> players;
        private Player player;
        private List<Transaction> transactions;
        private Transaction transaction;
        private List<Combat> combats;
        bool loginValid;
        bool passwordValid;
        bool emailValid;
        bool sumValid;
        bool dateValid;

        public MainPresenter(IView view)
        {
            this.view = view;
            service = new ServiceRepository();
            view.playersOkClick += onPlayersOkClick;
            view.transactionsOkClick += onTransactionsOkClick;
            view.combatsOkClick += onCombatsOkClick;
            view.playerSaveClick += onPlayerSaveClick;
            view.transactionSaveClick += onTransactionsSaveClick;
        }

        #region EventHandlers

        private void onPlayersOkClick(object sender, EventArgs e)
        {
            InfoForPlayerTable();
            view.PlayerTable = players;
        }

        private void onTransactionsOkClick(object sender, EventArgs e)
        {
            InfoForTransactionTable();
            view.TransactionsTable = transactions;
        }

        private void onCombatsOkClick(object sender, EventArgs e)
        {
            InfoForCombatTable();
            view.CombatsTable = combats;
        }

        private void onPlayerSaveClick(object sender, EventArgs e)
        {
            if (PlayersValidation())
            {
                ChangeSelectedPlayer();
                service.Save();
                view.SavePlayer = true;
            }
                PlayersErrorsVisible();
            
        }

        private void onTransactionsSaveClick(object sender, EventArgs e)
        {
            if (TransactionsValidation())
            {
                ChangeSelectedTransaction();
                service.Save();
                view.SaveTransaction = true;
            }
            TransactionsErrorsVisible();

        }

        #endregion

        #region Methods

        #region Validation

        #region Players
        private bool PlayersValidation()
        {
            LoginOrPasswordValid(true);
            LoginOrPasswordValid(false);
            ValidEmail();

            if (emailValid && loginValid && passwordValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ValidEmail()
        {
            if (view.SelectedPlayer.EMail != string.Empty)
            {
                if (view.SelectedPlayer.EMail.Contains("@") && view.SelectedPlayer.EMail.Contains("."))
                {
                    char[] currentEmail = view.SelectedPlayer.EMail.ToCharArray();
                    int NumbersOfNecessarySymbol = 0;

                    for (int i = 0; i < currentEmail.Length; i++)
                    {
                        if (!((currentEmail[i] >= 'A' && currentEmail[i] <= 'Z') || (currentEmail[i] >= 'a' && currentEmail[i] <= 'z') ||
                            (currentEmail[i] >= '0' && currentEmail[i] <= '9')))
                        {
                            if ((currentEmail[i] != '@') && (currentEmail[i] != '.'))
                            {
                                emailValid = false;
                                break;
                            }
                            else if (NumbersOfNecessarySymbol == 2)
                            {
                                emailValid = false;
                                break;
                            }
                            else
                            {
                                NumbersOfNecessarySymbol++;
                            }
                        }
                        view.SelectedPlayer.IsEmaillValid = true;
                        emailValid = true;
                    }

                }
                else
                {
                    emailValid = false;
                }
            }
            else
            {
                emailValid = true;
                view.SelectedPlayer.EMail = null;
                view.SelectedPlayer.IsEmaillValid = false;
            }
        }

        private void LoginOrPasswordValid(bool isLogin)
        {
            if (isLogin)
            {
                string login = view.SelectedPlayer.Login;
                loginValid = LatinAndNumbersValid(login) ? true : false;
            }
            else
            {
                string password = view.SelectedPlayer.Password;
                passwordValid = LatinAndNumbersValid(password) ? true : false;
            }
        }

        private bool LatinAndNumbersValid(string text)
        {
            char[] currentText = text.ToCharArray();

            for (int i = 0; i < currentText.Length; i++)
            {
                if (!((currentText[i] >= 'A' && currentText[i] <= 'Z') || (currentText[i] >= 'a' && currentText[i] <= 'z') ||
                    (currentText[i] >= '0' && currentText[i] <= '9')))
                {
                    return false;
                }
            }
            return true;
        }

        private void PlayersErrorsVisible()
        {
            view.EmailError = !emailValid;
            view.LoginError = !loginValid;
            view.PasswordError = !passwordValid;
        }
        #endregion

        #region Transactions

        private bool TransactionsValidation()
        {
            SumValidation();
            DateValidation();
            if (sumValid && dateValid)
            {
                return true;
            }
            return false;
        }
        
        private void DateValidation()
        {
            dateValid = true;
            if ((view.SelectedTransaction.Date == DateTime.MinValue))
            {
                dateValid = false;
            }
            
        }

        private void SumValidation()
        {
            sumValid = true;
            if (view.SelectedTransaction.Sum <= 0)
            {
                sumValid = false;
            }
        }

        private void TransactionsErrorsVisible()
        {
            view.DateError = !dateValid;
            view.SumError = !sumValid;
        }

        #endregion

        #endregion

        private void  InfoForPlayerTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.PTop:
                    players =  service.Players.GetTopPlayers().ToList();
                    break;

                case Enums.OutputInfoType.PDate:
                    players = service.Players.GetPlayersByRegist().ToList();
                    break;

                case Enums.OutputInfoType.PAlphabet:
                    players = service.Players.GetPlayersByAlphabet().ToList();
                    break;

                case Enums.OutputInfoType.PNumOfComb:
                    players = service.Players.GetPlayersByNumberOfGame().ToList();
                    break;

                case Enums.OutputInfoType.PValidEmail:
                    players = service.Players.GetValidEmailPlayers().ToList();
                    break;
                case Enums.OutputInfoType.PLogin:
                    players = service.Players.GetPlayerByLogin(view.SelectedPlayer.Login).ToList();
                    break;

                default:
                    break;
            }
        }

        private void ChangeSelectedPlayer()
        {
            player = service.Players.GetPlayerById(view.SelectedPlayer.Id); 
            player.Login = view.SelectedPlayer.Login;
            player.Password = view.SelectedPlayer.Password;
            player.EMail = view.SelectedPlayer.EMail;
        }

        private void InfoForTransactionTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.TSum:
                    transactions = service.Transactions.GetTransactionsBySum().ToList();
                    break;
                case Enums.OutputInfoType.TDate:
                    transactions = service.Transactions.GetTransactionsByDate().ToList();
                    break;
                case Enums.OutputInfoType.TLogin:
                    transactions = service.Transactions.GetTransactionsByLogin(view.SelectedPlayer.Login).ToList();
                    break;
                default:
                    break;
            }
        }

        private void ChangeSelectedTransaction()
        {
            transaction = service.Transactions.GetTransactionsById(view.SelectedTransaction.Id);
            transaction.Date = view.SelectedTransaction.Date;
            transaction.Sum = view.SelectedTransaction.Sum;
        }

        private void InfoForCombatTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.CType:
                    combats = service.Combats.GetCombatsByType().ToList();
                    break;
                case Enums.OutputInfoType.CLogin:
                    combats = service.Combats.GetCombatsByPlayer(view.SelectedPlayer.Login).ToList();
                    break;
                case Enums.OutputInfoType.CDate:
                    combats = service.Combats.GetCombatsByDate().ToList();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
