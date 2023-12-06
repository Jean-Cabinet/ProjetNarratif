using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Inventaire
    {
        public List<Item> inventaire = new();

        public Inventaire()
        {


        }

        public void Add (Item item)
        {
            inventaire.Add(item);
        }

        public void Sub(Item item)
        {
            inventaire.Remove(item);
        }

        public void See (Item item)
        {
            Console.WriteLine("Vous possédez dans votre inventaire ces objets : ");
            inventaire.ForEach(i => Console.WriteLine(i.name));
        }

        


        
    }
}
