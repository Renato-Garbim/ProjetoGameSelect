using AutoMapper;
using Dominio.Entidades;
using Dominio.Service.Interfaces;
using Game.Application.Interface;
using Game.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Application.Services
{
    public class JogoAppService : AppServiceBase<EntidadeGame, EntidadeGameDTO>, IJogoAppService
    {
        private readonly IGameService _gameService;

        public JogoAppService(IGameService gameService, IMapper mapper) : base(gameService, mapper)
        {
            _gameService = gameService;
        }

        
    }
}
