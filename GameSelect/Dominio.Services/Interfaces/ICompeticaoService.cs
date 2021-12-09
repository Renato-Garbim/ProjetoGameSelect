using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Service.Interfaces
{
    public interface ICompeticaoService
    {
        List<EntidadeGame> DefinirMelhorJogo(IEnumerable<EntidadeGame> listaGames);
    }
}
