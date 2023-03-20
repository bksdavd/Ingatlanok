using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngatlanokUjra
{
    public class Lakas
    {
        static int szam = 0;
        protected string azonosito, cim;
        protected int meret, ar, erdeklodok;
        protected bool eladva;

        public Lakas(string azonosito, string cim, int meret, int ar, int erdeklodok, bool eladva)
        {
            this.azonosito = azonosito;
            this.cim = cim;
            this.meret = meret;
            this.ar = ar;
            this.erdeklodok = erdeklodok;
            this.eladva = eladva;
        }

        public Lakas(string cim, int meret, int ar)
        {
            this.azonosito = (++szam).ToString();
            this.cim = cim;
            this.meret = meret;
            this.ar = ar;
        }

        public static int Szam { get => szam; set => szam = value; }
        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Meret { get => meret; set => meret = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Erdeklodok { get => erdeklodok; set => erdeklodok = value; }
        public bool Eladva { get => eladva; set => eladva = value; }

        public override string ToString()
        {
            return azonosito + ";" + cim + ";" + meret + ";" + ar + ";" + erdeklodok + ";" + eladva;
        }
    }
}
