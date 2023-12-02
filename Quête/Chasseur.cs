using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Chasseur : Ennemis
    {
        public int flèchesifrit {  get; set; }
        public int brulureifrit { get; set; }

        public Chasseur() 
        {
            this.brulureifrit = 1;
            this.flèchesifrit = 15;
            this.PV = 40;
            this.attaque = 5;
            this.expérience = 10;
            this.défense = 10;
            this.riposte = 15;
        }


    }
}
