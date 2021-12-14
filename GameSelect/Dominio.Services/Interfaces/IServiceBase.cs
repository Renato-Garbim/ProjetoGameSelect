using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Service.Interfaces
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        bool InsertRecord(TEntity objeto);
        bool UpdateRecord(TEntity objeto);
        IQueryable<TEntity> GetAllRecords();
        TEntity GetRecordById(int id);
        TEntity GetRecordById(Guid id);
        bool RemoveRecord(TEntity registro);
    }
}
