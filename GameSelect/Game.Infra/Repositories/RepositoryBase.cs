using Dominio.Service.Interfaces.Repository;
using Game.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly GameContext Db;
        protected readonly DbSet<TEntity> DBSet;

        private readonly string _strConexao;

        public RepositoryBase(GameContext db)
        {            
            Db = db;
            if (db == null)
                throw new ArgumentNullException(nameof(db));

            DBSet = Db.Set<TEntity>();

            _strConexao = Db.Database.GetDbConnection().ConnectionString;

        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        private async void AlterarBanco()
        {
            await Db.SaveChangesAsync();
        }

        public virtual IQueryable<TEntity> GetAllRecords()
        {
            var registros = DBSet.AsNoTracking().AsQueryable();
            return registros;
        }

        public virtual bool InsertRecord(TEntity obj)
        {
            var inseridoSucesso = false;

            try
            {
                DBSet.Add(obj);
                AlterarBanco();
                inseridoSucesso = true;
            }
            catch(DbUpdateException /* ex */)
            {
                inseridoSucesso = false;
            }
                       
            return inseridoSucesso;
        }

        public virtual bool UpdateRecord(TEntity obj)
        {
            var updateSucesso = false;

            try
            {
                DBSet.Update(obj);
                AlterarBanco();
                updateSucesso = true;
            }
            catch (DbUpdateException /* ex */)
            {
                updateSucesso = false;
            }

            
            
            return updateSucesso;
        }


    }
}
