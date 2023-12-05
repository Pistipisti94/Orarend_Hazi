using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanorarend
{
    internal class Orarendek
    {
        public int oraid;
        public string tantargy;
        public int sorszam;
        public string nap;

        public Orarendek(int oraid, string tantargy, int sorszam, string nap)
        {
            this.oraid = oraid;
            this.tantargy = tantargy;
            this.sorszam = sorszam;
            this.nap = nap;
        }
        public override string ToString()
        {
            return this.nap + " " + this.sorszam + " " + this.tantargy;
        }
    }
}
