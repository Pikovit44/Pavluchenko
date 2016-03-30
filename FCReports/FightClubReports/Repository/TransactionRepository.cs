using FightClubReports.Data;
using FightClubReports.Entitys;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {

        public TransactionRepository()
        {
            this.db = new Context(); // сделать фассад 
        }

        public IEnumerable<Transaction> GetTransactionsByDate()
        {
            return db.Transaction
                .OrderBy(d => d.Date);
        }

        public IEnumerable<Transaction> GetTransactionsByLogin(string login)
        {
            return db.Transaction
                .Where(p => p.Player.Login == login);
        }

        public IEnumerable<Transaction> GetTransactionsBySum()
        {
            return db.Transaction
                .OrderByDescending(s => s.Sum);
        }
    }
}
