using FightClubReports.Data;
using FightClubReports.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClubReports.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context db;
        private IPlayerRepository playerRepository;
        private ICombatRepository combatRepository;
        private ITransactionRepository transactionRepository;

        public ServiceRepository(Context db)
        {
            this.db = db;
        }

        public ICombatRepository Combat
        {
            get
            {
                if (combatRepository == null)
                {
                    combatRepository = new CombatRepository(db);
                }
                return combatRepository;
            }
        }

        public IPlayerRepository Player
        {
            get
            {
                if (playerRepository == null)
                {
                    playerRepository = new PlayerRepository(db);
                }
                return playerRepository;
            }
        }

        public ITransactionRepository Transaction
        {
            get
            {
                if (transactionRepository == null)
                {
                    transactionRepository = new TransactionRepository(db);
                }
                return transactionRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
