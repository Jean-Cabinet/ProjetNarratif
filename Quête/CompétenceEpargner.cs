using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class CompétenceEpargner : Compétences
    {

        public CompétenceEpargner(string name, string description, int attaquecomp)
        {
            this.name = name;
            this.description = description;
            this.attaquecomp = attaquecomp;

        }

        public void Éxecuter(Ennemis E, Edvars C)
        {
            Console.WriteLine("Edvars");
            E.PV = E.PV - this.attaquecomp;
            C.défenseEdvars = C.défenseEdvars + 20;


        }








    }
}
