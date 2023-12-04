using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Mandragore: Item
    {
        public int nombre {  get; set; }    

        public Mandragore(string name, string type, int nombre) 
        { 
            this.nombre = 3;
            this.type = type;
            this.name = name;
        
        } 
    }
}
