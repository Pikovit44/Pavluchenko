﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface ICombatRepository : IRepository<Combat>
    {
        IEnumerable<Combat> GetCombatsByType(string type);
        IEnumerable<Combat> GetCombatsByPlayer(string login);

    }
}
