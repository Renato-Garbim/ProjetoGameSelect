using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Mercurio.WebApp.Application.Interface.Service
{
    public interface IAppServiceBase<TEntity, TEntityViewModel> where TEntity : class
        where TEntityViewModel : class        

    {
        TEntity MapperViewModelParaEntity(TEntityViewModel obj);

        bool AdicionarOuAtualizar(TEntityViewModel obj);
        bool Remover(int registroId);
        bool Remover(Guid registroId);

        TEntityViewModel ObterPorId(int registroId);
        TEntityViewModel ObterPorId(Guid registroId);
        IEnumerable<TEntityViewModel> ObterTodos();      
        int TotalDeRegistros();
    }
}
