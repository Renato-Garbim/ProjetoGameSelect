using Dominio.Entidades;
using Dominio.Service.Interfaces;
using Moq;
using System;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using Dominio.Service.Services;
using Game.Domain.Services.Teste.Dados;

namespace Game.Dominio.Teste
{
    public class TestCompeticaoService
    {

        [ClassData(typeof(GamesParaTesteGameA))]
        [Theory]
        public void DefinirGameVencedorOndeGameATemMaiorNota(EntidadeGame GameA, EntidadeGame GameB)
        {
            //arrange
            var servico = new CompeticaoService();

            //act
            var result = servico.DefinirGameVencedor(GameA, GameB);

            //assert

            Assert.Equal(GameA, result);
        }

        [ClassData(typeof(GamesParaTesteGameB))]
        [Theory]
        public void DefinirGameVencedorOndeGameBTemMaiorNota(EntidadeGame GameA, EntidadeGame GameB)
        {
            //arrange
            var servico = new CompeticaoService();

            //act
            var result = servico.DefinirGameVencedor(GameA, GameB);

            //assert

            Assert.Equal(GameB, result);
        }

        [ClassData(typeof(GamesParaTesteDesempateGameA))]
        [Theory]
        public void DefinirDesempateOndeGameATemMaiorNota(EntidadeGame GameA, EntidadeGame GameB)
        {
            //arrange
            var servico = new CompeticaoService();

            //act
            var result = servico.DefinirDesempate(GameA, GameB);

            //assert

            Assert.Equal(GameA, result);
        }


        [ClassData(typeof(GamesParaTesteDesempateGameB))]
        [Theory]
        public void DefinirDesempateOndeGameBTemMaiorNota(EntidadeGame GameA, EntidadeGame GameB)
        {
            //arrange
            var servico = new CompeticaoService();

            //act
            var result = servico.DefinirDesempate(GameA, GameB);

            //assert

            Assert.Equal(GameB, result);
        }

    }
}
