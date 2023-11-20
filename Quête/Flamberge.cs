using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Flamberge : Item
    {
        public int attaque = 12;




        public Flamberge(string name,string type,int attaque)
        {
            this.name = name;
            this.type = type;
            this.attaque = attaque;


        }

    }
}
