using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface IGameController
    {
        void Fight();
        void SetHp();
        void setData(int fight, int win, int tie, int losse);
    }
}
