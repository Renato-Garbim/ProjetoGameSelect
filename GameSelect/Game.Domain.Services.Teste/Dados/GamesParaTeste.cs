using Dominio.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Game.Domain.Services.Teste.Dados
{
    public class GamesParaTesteGameA : IEnumerable<object[]>
    {


        public IEnumerator<object[]> GetEnumerator()
        {

            yield return new object[] { new EntidadeGame(1, Guid.NewGuid(), "The Legend of Zelda: Ocarina of Time (N64)", 1998, 99.9), new EntidadeGame(2, Guid.NewGuid(), "Tony Hawk's Pro Skater 2 (PS)", 2000, 98.9) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

    public class GamesParaTesteGameB : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new EntidadeGame(1, Guid.NewGuid(), "Tony Hawk's Pro Skater 2 (PS)", 2000, 98.9), new EntidadeGame(2, Guid.NewGuid(), "The Legend of Zelda: Ocarina of Time (N64)", 1998, 99.9) };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

    public class GamesParaTesteDesempateGameA : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new EntidadeGame(1, Guid.NewGuid(), "Super Mario Galaxy 2 (WII)", 2010, 97.9), new EntidadeGame(2, Guid.NewGuid(), "Super Mario Galaxy (WII)", 2007, 97.9) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

    public class GamesParaTesteDesempateGameB : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new EntidadeGame(1, Guid.NewGuid(), "Super Mario Galaxy  (WII)", 2007, 97.9), new EntidadeGame(2, Guid.NewGuid(), "Super Mario Galaxy 2 (WII)", 2010, 97.9) };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }





}
