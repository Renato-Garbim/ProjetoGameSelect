using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Dominio.Teste.ObjetosTeste
{
    public class Shelf
    {
        private List<string> items = new List<string>();

        public void Put(string item)
        {
            if (!string.IsNullOrEmpty(item))
            {
                this.items.Add(item);
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
