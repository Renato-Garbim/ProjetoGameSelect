using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Domain.Services.Teste.Dados
{
    public class Shelf
    {
        private List<string> items = new List<string>();

        public void Put(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        }

        public bool Take(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                return true;
            }

            return false;
        }
    }
}
