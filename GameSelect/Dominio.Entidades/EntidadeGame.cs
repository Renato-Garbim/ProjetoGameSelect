using System;

namespace Dominio.Entidades
{
    public class EntidadeGame
    {
        public int EntidadeGameId { get; private set; }
        public Guid EntidadeGameGuid { get; private set; }       
        public string titulo { get; private set; }
        public int ano { get; private set; }
        public double nota { get; private set; }

        public EntidadeGame()
        {

        }        

        public EntidadeGame(int entidadeGameId, Guid entidadeGameGuid, string Titulo, int anoLancamento, double Nota)
        {
            EntidadeGameId = entidadeGameId;
            EntidadeGameGuid = entidadeGameGuid;            
            titulo = Titulo;
            ano = anoLancamento;
            nota = Nota;
        }


    }

   
}
