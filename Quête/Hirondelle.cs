using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Hirondelle : Item
    {
        public int HealingAmount = 12;




        public Hirondelle(string name, string type, int HealingAmount)
        {
            this.name = name;
            this.type = type;
            this.HealingAmount = HealingAmount;


        }

       

    }
}
