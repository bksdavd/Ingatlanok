using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngatlanokUjra
{
    internal class Haz:Lakas
    {
        int telek, szint;

        public Haz(string cim, int meret, int ar, int telek, int szint):base(cim, meret, ar)
        {
            this.telek = telek;
            this.szint = szint;
        }

        public Haz(string azonosito, string cim, int meret, int ar, int telek, int szint, int erdeklodok, bool eladva):base(azonosito, cim, meret, ar, erdeklodok, eladva)
        {
            this.telek = telek;
            this.szint = szint;
        }

        public int Telek { get => telek; set => telek = value; }
        public int Szint { get => szint; set => szint = value; }

        public override string ToString()
        {
            return azonosito + ";" + cim + ";" + meret + ";" + ar + ";" + telek + ";" + szint + ";" + erdeklodok + ";" + eladva;
        }
    }
}
