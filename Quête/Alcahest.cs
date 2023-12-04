using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Alcahest : Item
    {
        public int  nombre {  get; set; }   


        public Alcahest(string name, string type, int nombre) 
        {
            this.name = name;
            this.type = type;
            this.nombre = nombre;

        }


    }
}
