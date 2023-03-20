using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngatlanokUjra
{
    internal class Eladas
    {
        Lakas lakas;
        string vevo;
        int eladasiAr;

        public Eladas(Lakas lakas, string vevo, int eladasiAr)
        {
            this.lakas = lakas;
            this.vevo = vevo;
            this.eladasiAr = eladasiAr;
        }

        public string Vevo { get => vevo; set => vevo = value; }
        public int EladasiAr { get => eladasiAr; set => eladasiAr = value; }
        internal Lakas Lakas { get => lakas; set => lakas = value; }

        public override string ToString()
        {
            return lakas.ToString() + ";" + vevo + ";" + eladasiAr;
        }
    } 
}
