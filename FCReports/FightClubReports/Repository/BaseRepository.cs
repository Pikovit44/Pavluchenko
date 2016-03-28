using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightClubReports.Repository.Interfaces;
using FightClubReports.Data;
using System.Data.Entity;

namespace FightClubReports.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected Context db;

        public BaseRepository(Context db)
        {
            this.db = db;
        }

        public void Create(TEntity item)
        {
            db.Set<TEntity>().Add(item);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            db.Set<TEntity>().AddRange(entities);
        }
        
        public void Delete(TEntity item)
        {
            db.Set<TEntity>().Remove(item);
        }

        public void DeleteById(int id)
        {
            TEntity item = db.Set<TEntity>().Find(id);
            if (item != null)
            {
                db.Set<TEntity>().Remove(item);
            }
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
