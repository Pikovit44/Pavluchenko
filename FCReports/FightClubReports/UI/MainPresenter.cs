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
        private readonly ServiceRepository facade;
        public MainPresenter(IView view)
        {
            this.view = view;
            facade = new ServiceRepository(new Context());
            view.OkClick += onOkClick;
            view.SaveClick += onSaveClick;
        }

        #region EventHandlers
        private void onSaveClick(object sender, EventArgs e)
        {
            SaveByType();
            MessageBox.Show(Resources.successfulSaving, Resources.saveChanges, MessageBoxButtons.OK);
        }

        private void onOkClick(object sender, EventArgs e)
        {
            ChooseTypeOfRequest();
        }
        #endregion

        #region Methods
        private void ChooseTypeOfRequest()
        {
            switch (view.InfoType)
            {
                case Enums.ViewInfoType.User:
                    InfoForPlayerTable();
                    break;
                case Enums.ViewInfoType.Transaction:
                    InfoForTransactionTable();
                    break;
                case Enums.ViewInfoType.Combat:
                    InfoForCombatTable();
                    break;
                default:
                    break;
            }
        }

        private void SaveByType()
        {
            switch (view.InfoType)
            {
                case Enums.ViewInfoType.User:
                    facade.Player.Save();
                    break;
                case Enums.ViewInfoType.Transaction:
                    facade.Transaction.Save();
                    break;
                case Enums.ViewInfoType.Combat:
                    facade.Combat.Save();
                    break;
                default:
                    break;
            }
        }

        private void  InfoForPlayerTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.UTop:
                    view.Table = facade.Player.GetTopPlayers();
                    break;

                case Enums.OutputInfoType.UDate:
                    view.Table = facade.Player.GetPlayersByRegist();
                    break;

                case Enums.OutputInfoType.UAlphabet:
                    view.Table = facade.Player.GetPlayersByLogin();
                    break;

                case Enums.OutputInfoType.UNumOfComb:
                    view.Table = facade.Player.GetPlayersByNumberOfGame();
                    break;

                case Enums.OutputInfoType.UNumOfTransact:
                    view.Table = facade.Player.GetPlayersByNumberOfTransactions();
                    break;

                case Enums.OutputInfoType.UValidEmail:
                    view.Table = facade.Player.GetValidEmailPlayers();
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
                    view.Table = facade.Transaction.GetTransactionsBySum();
                    break;
                case Enums.OutputInfoType.TDate:
                    view.Table = facade.Transaction.GetTransactionsByDate();
                    break;
                case Enums.OutputInfoType.TLogin:
                    view.Table = facade.Transaction.GetTransactionsByLogin(view.CurrentLogin);
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
                    view.Table = facade.Combat.GetCombatsByType();
                    break;
                case Enums.OutputInfoType.CLogin:
                    view.Table = facade.Combat.GetCombatsByPlayer(view.CurrentLogin);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
