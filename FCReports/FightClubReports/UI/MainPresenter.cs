using FightClubReports.Data;
using FightClubReports.Interfaces;
using FightClubReports.Properties;
using FightClubReports.Repository;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClubReports
{
    public class MainPresenter
    {
        private readonly IView view;
        private readonly ServiceRepository service;

        public MainPresenter(IView view)
        {
            this.view = view;
            service = new ServiceRepository();
            view.playersOkClick += onPlayersOkClick;
            view.transactionsOkClick += onTransactionsOkClick;
            view.combatsOkClick += onCombatsOkClick;
        }

        #region EventHandlers

        private void onPlayersOkClick(object sender, EventArgs e)
        {
            InfoForPlayerTable();
        }

        private void onTransactionsOkClick(object sender, EventArgs e)
        {
            InfoForTransactionTable();
        }

        private void onCombatsOkClick(object sender, EventArgs e)
        {
            InfoForCombatTable();
        }

        #endregion

        #region Methods
       
        private void  InfoForPlayerTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.UTop:
                    view.PlayerTable = service.Player.GetTopPlayers();
                    break;

                case Enums.OutputInfoType.UDate:
                    view.PlayerTable = service.Player.GetPlayersByRegist();
                    break;

                case Enums.OutputInfoType.UAlphabet:
                    view.PlayerTable = service.Player.GetPlayersByLogin();
                    break;

                case Enums.OutputInfoType.UNumOfComb:
                    view.PlayerTable = service.Player.GetPlayersByNumberOfGame();
                    break;

                case Enums.OutputInfoType.UNumOfTransact:
                    view.PlayerTable = service.Player.GetPlayersByNumberOfTransactions();
                    break;

                case Enums.OutputInfoType.UValidEmail:
                    view.PlayerTable = service.Player.GetValidEmailPlayers();
                    break;

                default:
                    break;
            }
        }

        private void InfoForTransactionTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.TSum:
                    view.TransactionsTable = service.Transaction.GetTransactionsBySum();
                    break;
                case Enums.OutputInfoType.TDate:
                    view.TransactionsTable = service.Transaction.GetTransactionsByDate();
                    break;
                case Enums.OutputInfoType.TLogin:
                    view.TransactionsTable = service.Transaction.GetTransactionsByLogin(view.CurrentLogin);
                    break;
                default:
                    break;
            }
        }
        private void InfoForCombatTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.CType:
                    view.CombatsTable = service.Combat.GetCombatsByType();
                    break;
                case Enums.OutputInfoType.CLogin:
                    view.CombatsTable = service.Combat.GetCombatsByPlayer(view.CurrentLogin);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
