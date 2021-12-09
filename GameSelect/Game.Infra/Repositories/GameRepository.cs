using Dominio.Entidades;
using Dominio.Service.Interfaces.Repository;
using Game.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Infra.Repositories
{
    public class GameRepository : RepositoryBase<EntidadeGame>, IGameRepository
    {
        public GameRepository(GameContext db) : base(db)
        {

        }
    }
}
