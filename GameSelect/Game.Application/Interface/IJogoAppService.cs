using Dominio.Entidades;
using Game.DTO;
using Mercurio.WebApp.Application.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Application.Interface
{
    public interface IJogoAppService : IAppServiceBase<EntidadeGame, EntidadeGameDTO>
    {

    }
}
