using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Inventairemarchand
    {

        public List<Item> inventairemarchand = new();

        public Inventairemarchand()
        {

        }

        public void Add(Item item)
        {
            inventairemarchand.Add(item);
        }

        public void Sub(Item item)
        {
            inventairemarchand.Remove(item);
        }

        public void See(Item item)
        {
            inventairemarchand.ForEach(i => Console.WriteLine(i.name));
        }




    }
}
