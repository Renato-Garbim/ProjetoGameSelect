using Dominio.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Game.DTO;
using Dominio.Entidades;
using Newtonsoft.Json;

namespace GameSelect.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ICompeticaoService _competicaoService;
        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger, ICompeticaoService competicaoService)
        {
            _logger = logger;
            _competicaoService = competicaoService;
        }

        [HttpGet]
        public void Get()
        {           

        }

        [HttpPost]
        public IActionResult Post([FromBody] List<EntidadeGameDTO> listaJogos)
        {
            var lista = new List<EntidadeGame>();
            var guid = Guid.NewGuid();

            foreach (var jogo in listaJogos)
            {
                lista.Add(new EntidadeGame(jogo.EntidadeGameId, guid, jogo.titulo, jogo.ano, jogo.nota));
            }

            var ganhadores = _competicaoService.DefinirMelhorJogo(lista);

            if (ganhadores == null)
            {
                return BadRequest("Lista em formato indevido para a competição.");
            }

            return Ok(JsonConvert.SerializeObject(ganhadores));

        }
    }
}
