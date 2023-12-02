using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class CompétenceSacrifice : Compétences
    {
        public CompétenceSacrifice(string name,string description, int attaquecomp)
        {
            this.name = name;
            this.description = description;
            this.attaquecomp = attaquecomp;

        }

        public void Éxecuter(Ennemis E,Edvars C)
        {
            this.attaquecomp = 20;
            E.PV = E.PV - this.attaquecomp;
            E.défense = E.défense - 10;

        }




    }
}
