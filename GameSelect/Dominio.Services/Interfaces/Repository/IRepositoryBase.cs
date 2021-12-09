using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Service.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAllRecords();
        bool InsertRecord(TEntity obj);
        bool UpdateRecord(TEntity obj);
    }
}
