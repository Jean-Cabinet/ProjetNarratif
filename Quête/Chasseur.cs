using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Chasseur : Ennemis
    {

        public Chasseur() 
        {

            this.PV = 20;
            this.attaque = 5;
            this.expérience = 10;

        }


    }
}
