using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Nécrophages : Ennemis
    {
        
        public int soufflepesti {  get; set; }
        public int nécrose {  get; set; }   
         
        public Nécrophages()
        {
            this.PV = 30;
            this.attaque = 5;
            this.expérience = 10;
            this.riposte = 10;
            this.soufflepesti = 12;
            this.nécrose = 2;

        }



    }
}
