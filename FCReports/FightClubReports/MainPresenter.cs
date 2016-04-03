using FightClubReports.Data;
using FightClubReports.Interfaces;
using FightClubReports.Repository;
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
        private readonly FacadeRepository facade;
        public MainPresenter(IView view)
        {
            this.view = view;
            facade = new FacadeRepository(new Context());
            view.OkClick += onOkClick;
        }



        private void onOkClick(object sender, EventArgs e)
        {
            ChooseTypeOfRequest();
        }

        private void ChooseTypeOfRequest()
        {
            switch (view.InfoType)
            {
                case Enums.ViewInfoType.User:
                    InfoForPlayerTable();
                    break;
                case Enums.ViewInfoType.Transaction:
                    break;
                case Enums.ViewInfoType.Combat:
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
                    view.PlayerTable = facade.Player.GetTopPlayers();
                    break;
                case Enums.OutputInfoType.UDate:
                    view.PlayerTable = facade.Player.GetPlayersByRegist();
                    break;
                case Enums.OutputInfoType.UAlphabet:
                    view.PlayerTable = facade.Player.GetPlayersByLogin();
                    break;
                case Enums.OutputInfoType.UNumOfComb:
                    view.PlayerTable = facade.Player.GetPlayersByNumberOfGame();
                    break;
                case Enums.OutputInfoType.UNumOfTransact:
                    view.PlayerTable = facade.Player.GetPlayersByNumberOfTransactions();
                    break;
                default:
                    break;
            }
        }





        private void InfoFowrPlayerTable()
        {
            switch (view.OutputInfo)
            {
                case Enums.OutputInfoType.Unknown:
                    break;
                case Enums.OutputInfoType.UTop:
                    break;
                case Enums.OutputInfoType.UDate:
                    break;
                case Enums.OutputInfoType.UAlphabet:
                    break;
                case Enums.OutputInfoType.UNumOfComb:
                    break;
                case Enums.OutputInfoType.UNumOfTransact:
                    break;
                case Enums.OutputInfoType.TSum:
                    break;
                case Enums.OutputInfoType.TDate:
                    break;
                case Enums.OutputInfoType.TLogin:
                    break;
                case Enums.OutputInfoType.CType:
                    break;
                case Enums.OutputInfoType.CLogin:
                    break;
                default:
                    break;
            }


        }
    }
}
