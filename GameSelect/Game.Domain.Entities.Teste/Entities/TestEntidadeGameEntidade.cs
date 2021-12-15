using System;
using Dominio.Entidades;
using Mercurio.Domain.Entities;
using Xunit;

namespace Mercurio.Domain.Entities.Test.Entities
{
    public class TestEntidadeGameEntidade
    {

        [Fact]
        public void FalharQuandoForUsadoConstutorVazio()
        {
            // arrange
            var entidade = new EntidadeGame();

            // act
            var results = entidade.EntidadeEhValida();


            // asser
            Assert.False(results);

        }

        //int entidadeGameId, Guid entidadeGameGuid, string Titulo, int anoLancamento, double Nota


        [InlineData(0, "00000000-0000-0000-0000-000000000000", "", 0, 0)]
        [InlineData(0, "800e0ca1-cdd2-4883-8f3e-d0f8a4e6cda7", "", 1900, 0)]
        [InlineData(0, "800e0ca1-cdd2-4883-8f3e-d0f8a4e6cda7", "Titulo", 0, 10)]
        [Theory]
        public void EntidateEhValida_FalharQuandoNaoEstiverEmConformidade(int entidadeGameId, string entidadeGameGuid, string titulo, int anoLancamento, double nota)
        {
            // arrange
            Guid.TryParse(entidadeGameGuid, out var EntidadeGame);
            var entidade = new EntidadeGame(entidadeGameId, EntidadeGame, titulo, anoLancamento, nota);

            // act
            var results = entidade.EntidadeEhValida();

            // assert
            Assert.False(results);

        }

        [InlineData(0, "800e0ca1-cdd2-4883-8f3e-d0f8a4e6cda7","Titulo", 1900, 5)]
        [Theory]
        public void EntidateEhValida_OkQuandoEstiverEmConformidade(int entidadeGameId, string entidadeGameGuid, string titulo, int anoLancamento, double nota)
        {
            // arrange
            Guid.TryParse(entidadeGameGuid, out var EntidadeGame);
            var entidade = new EntidadeGame(entidadeGameId, EntidadeGame, titulo, anoLancamento, nota);

            // act
            var results = entidade.EntidadeEhValida();

            // assert
            Assert.True(results);

        }

    }
}
