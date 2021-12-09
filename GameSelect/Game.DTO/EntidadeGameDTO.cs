using System;

namespace Game.DTO
{
    public class EntidadeGameDTO
    {
        public int EntidadeGameId { get; set; }
        public Guid EntidadeGameGuid { get; set; }        
        public string titulo { get; set; }
        public int ano { get; set; }
        public double nota { get; set; }

        public EntidadeGameDTO()
        {

        }
    }
}
