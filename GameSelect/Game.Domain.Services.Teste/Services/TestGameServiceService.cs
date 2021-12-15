using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;
using Dominio.Service.Interfaces.Repository;
using Dominio.Service.Services;
using Moq;
using Xunit;

namespace Mercurio.Domain.Test.Servicos
{
    public class TestGameServiceService
    {

        [InlineData(0, "00000000-0000-0000-0000-000000000000", "", 0, 0)]
        [Theory]
        public void Insert_FalharQuandoEntidadeNaoEstiverEmConformidade(int entidadeGameId, string entidadeGameGuid, string titulo, int anoLancamento, double nota)
        {
            //arrange

            var mock = new Mock<IGameRepository>();

            Guid.TryParse(entidadeGameGuid, out var entidadeGame);
            var entidade = new EntidadeGame(entidadeGameId,entidadeGame, titulo, anoLancamento, nota);

            var servico = new GameService(mock.Object);

            mock.Setup(x => x.InsertRecord(entidade)).Returns(false);

            //act
            var result = servico.InsertRecord(entidade);

            //assert

            Assert.False(result);
        }
        
        [InlineData(0, "800e0ca1-cdd2-4883-8f3e-d0f8a4e6cda7", "", 1, 1)]
        [Theory]
        public void Insert_OkQuandoEntidadeEstiverEmConformidade(int entidadeGameId, string entidadeGameGuid, string titulo, int anoLancamento, double nota)
        {
            //arrange

            var mock = new Mock<IGameRepository>();

            Guid.TryParse(entidadeGameGuid, out var entidadeGame);
            var entidade = new EntidadeGame(entidadeGameId, entidadeGame, titulo, anoLancamento, nota);

            var servico = new GameService(mock.Object);

            mock.Setup(x => x.InsertRecord(entidade)).Returns(true);

            //act
            var result = servico.InsertRecord(entidade);

            //assert

            Assert.True(result);
        }

        [InlineData(0, "00000000-0000-0000-0000-000000000000", "", 0, 0)]
        [Theory]
        public void Update_FalharQuandoEntidadeNaoEstiverEmConformidade(int entidadeGameId, string entidadeGameGuid, string titulo, int anoLancamento, double nota)
        {           
            //arrange

            var mock = new Mock<IGameRepository>();

            Guid.TryParse(entidadeGameGuid, out var entidadeGame);
            var entidade = new EntidadeGame(entidadeGameId, entidadeGame, titulo, anoLancamento, nota);

            var servico = new GameService(mock.Object);

            mock.Setup(x => x.UpdateRecord(entidade)).Returns(false);

            //act
            var result = servico.UpdateRecord(entidade);

            //assert

            Assert.False(result);
        }

        
        [InlineData(0, "800e0ca1-cdd2-4883-8f3e-d0f8a4e6cda7", "", 1, 1)]
        [Theory]
        public void Update_OkQuandoEntidadeEstiverEmConformidade(int entidadeGameId, string entidadeGameGuid, string titulo, int anoLancamento, double nota)
        {
            //arrange

            var mock = new Mock<IGameRepository>();

            Guid.TryParse(entidadeGameGuid, out var entidadeGame);
            var entidade = new EntidadeGame(entidadeGameId, entidadeGame, titulo, anoLancamento, nota);

            var servico = new GameService(mock.Object);

            mock.Setup(x => x.UpdateRecord(entidade)).Returns(true);

            //act
            var result = servico.UpdateRecord(entidade);

            //assert

            Assert.True(result);
        }
    }
}
