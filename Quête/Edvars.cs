using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
        internal class Edvars
        {
            public int PVEdvars { get; set; }
            public int Gold { get; set; }
            public int PointexperienceSacrifice { get; set; }
            public int PointexperienceEpargner { get; set; }
            public int levelSacrifice { get; set; }
            public int levelEpargner { get; set; }
            public Inventaire inventaire {  get; set; } 
         public Edvars() 
         { 
            this.PVEdvars = 50;
            this.Gold = 10;
            this.levelEpargner = 1;
            this.levelSacrifice = 1;
            this.PointexperienceSacrifice = 0;
            this.PointexperienceSacrifice = 0;
            this.inventaire = new Inventaire();
            this.inventaire.Add(new Flamberge("Gwynbleidd", "flamberge", 12));

                            
         }   
        }




    
}
