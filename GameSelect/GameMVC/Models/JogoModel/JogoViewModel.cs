using Game.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameMVC.Models.JogoModel
{
    public class JogoViewModel
    {
        public IEnumerable<EntidadeGameDTO> Lista { get; set; }
    }
}
