using Dominio.Entidades;
using Dominio.Service.Interfaces;
using Dominio.Service.Interfaces.Repository;
using System;

namespace Dominio.Service.Services
{
    public class GameService : ServiceBase<EntidadeGame>, IGameService
    {
        private readonly IGameRepository _repository;

        public GameService(IGameRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
