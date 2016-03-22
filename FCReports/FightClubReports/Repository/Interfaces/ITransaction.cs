using FightClubReports.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository.Interfaces
{
    public interface ITransaction : IRepository<Transaction>
    {
        List<Player> GetListOfPlayersBySum();
    }
}
