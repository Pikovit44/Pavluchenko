using Enums;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Entitys.Combat
{
    public interface IRoundLog : IRepository<RoundLog>
    {
        List<RoundLog> GetRoundLogsByPart(PartOfBody part);
    }
}
