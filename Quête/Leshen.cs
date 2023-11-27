using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Leshen : Ennemis
    {

        
       
        public int nuéecorbeaux { get; set; }
        

        public Leshen()
        {
            this.PV = 50;
            this.attaque = 15;
            this.nuéecorbeaux = 17;
            this.défense = 10;
            this.riposte = 10;
            this.expérience = 100;
        }


   



    }
}
