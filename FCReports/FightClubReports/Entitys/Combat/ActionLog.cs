using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Entitys.Combat
{
    public class ActionLog
    {
        Hitlog hitLog;
        BlockLog blockLog;

        public RoundLog RoundLog
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
