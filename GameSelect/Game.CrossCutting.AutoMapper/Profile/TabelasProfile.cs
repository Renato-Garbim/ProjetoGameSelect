

using Dominio.Entidades;
using Game.DTO;

namespace Mercurio.WebApp.CrossCutting.AutoMapper.Profile
{
    public class TabelasProfile : global::AutoMapper.Profile
    {
        public TabelasProfile()
        {

           CreateMap<EntidadeGame, EntidadeGameDTO>();

           CreateMap<EntidadeGameDTO, EntidadeGame>()
               .ConstructUsing(x =>new EntidadeGame(x.EntidadeGameId, x.EntidadeGameGuid, x.titulo, x.ano, x.nota));

        }
    }
}