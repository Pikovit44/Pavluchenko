﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubApp.Inerfaces
{
    public interface ITextInfo
    {
        void SetMessage();
        void WinnerName();
        string PatrtToString(PartOfBody part);
    }
}
