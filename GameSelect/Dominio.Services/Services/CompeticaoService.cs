using Dominio.Entidades;
using Dominio.Service.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace Dominio.Service.Services
{
    public class CompeticaoService : ICompeticaoService
    {
        public List<EntidadeGame> DefinirMelhorJogo(IEnumerable<EntidadeGame> listaGames)
        {
            if (!ListaAptaParaACompetição(listaGames)) return null;

            var listaSegundaFase = IniciarCompeticao(listaGames);

            var listaPrimeirosColocados = IniciarCompeticao(listaSegundaFase);

            return listaPrimeirosColocados;
        }

        private bool ListaAptaParaACompetição(IEnumerable<EntidadeGame> listaGames)
        {
            return listaGames.Count() == 8;
        }

        private List<EntidadeGame> IniciarCompeticao(IEnumerable<EntidadeGame> listaGames)
        {
            var listaPrimeiraFase = listaGames.OrderBy(x => x.titulo).ToList();
            var listaVencedores = new List<EntidadeGame>();

            while (listaPrimeiraFase.Count() != 0)
            {
                var jogoA = listaPrimeiraFase.First();
                var jogoB = listaPrimeiraFase.Last();

                var vencedor = DefinirGameVencedor(jogoA, jogoB);
                listaVencedores.Add(vencedor);

                listaPrimeiraFase.Remove(listaPrimeiraFase.First());
                listaPrimeiraFase.Remove(listaPrimeiraFase.Last());
            }

            return listaVencedores;
        }

        public EntidadeGame DefinirGameVencedor(EntidadeGame GameA, EntidadeGame GameB)
        {
            if(GameA.nota > GameB.nota)
            {
                return GameA;
            }

            if(GameA.nota < GameB.nota)
            {
                return GameB;
            }

            if(GameA.nota == GameB.nota)
            {
                return DefinirDesempate(GameA, GameB);
            }

            return new EntidadeGame();
        }

        public EntidadeGame DefinirDesempate(EntidadeGame GameA, EntidadeGame GameB)
        {
            if(GameA.ano > GameB.ano)
            {
                return GameA;
            }

            if (GameB.ano > GameA.ano)
            {
                return GameB;
            }

            var listaParaDefinirOrdemAlfabetica = new List<EntidadeGame>();

            listaParaDefinirOrdemAlfabetica.Add(GameA);
            listaParaDefinirOrdemAlfabetica.Add(GameB);

            return listaParaDefinirOrdemAlfabetica.OrderBy(x => x.titulo).First();
        }
    }
}