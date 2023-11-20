using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Quête
{
    internal class Huiles : Item
    {
        public int huileleshi = 0;
        public int huileelven = 0;
        public int huileent = 0;
        public int huilelycan = 0;
        public int huilealfi = 0;

        public Huiles(string name, string type, int huileleshi, int huileelven, int huileent, int huilelycan, int huilealfi)
        {
            this.name = name;
            this.type = type;
            this.huileleshi = huileleshi;
            this.huileent = huileent;
            this.huileelven = huileelven;
            this.huilelycan = huilelycan;
            this.huilealfi = huilealfi;
            

        }

    }
}
