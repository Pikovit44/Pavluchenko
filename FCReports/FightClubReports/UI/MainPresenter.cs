using FightClubReports.Data;
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
                case Enums.OutputInfoType.PTop:
                    view.PlayerTable = service.Player.GetTopPlayers();
                    break;

                case Enums.OutputInfoType.PDate:
                    view.PlayerTable = service.Player.GetPlayersByRegist();
                    break;

                case Enums.OutputInfoType.PAlphabet:
                    view.PlayerTable = service.Player.GetPlayersByAlphabet();
                    break;

                case Enums.OutputInfoType.PNumOfComb:
                    view.PlayerTable = service.Player.GetPlayersByNumberOfGame();
                    break;

                case Enums.OutputInfoType.PValidEmail:
                    view.PlayerTable = service.Player.GetValidEmailPlayers();
                    break;
                case Enums.OutputInfoType.PLogin:
                    view.PlayerTable = service.Player.GetPlayerByLogin(view.CurrentLogin);
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
                case Enums.OutputInfoType.CDate:
                    view.CombatsTable = service.Combat.GetCombatsByDate();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
