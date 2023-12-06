using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Mandragore: Item
    {
           

        public Mandragore(string name, string type, int nombre, int prix) 
        { 
            this.nombre = nombre;
            this.type = type;
            this.name = name;
            this.prix = prix;
        
        } 
    }
}
