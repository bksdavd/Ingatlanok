using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IngatlanokUjra
{
    public partial class EladasokForm : Form
    {
        List<Eladas> eladasok = new List<Eladas>();
        public EladasokForm()
        {
            InitializeComponent();
            Beolvas();
            TablabaIr();
        }

        private void TablabaIr()
        {
            foreach (Eladas el in eladasok)
            {
                DataGridViewRow row = (DataGridViewRow)dgvEladasok.Rows[0].Clone();
                row.Cells[0].Value = el.Lakas.Cim;
                row.Cells[1].Value = el.Lakas.Meret;
                if (el.Lakas is Haz)
                {
                    Haz h = el.Lakas as Haz;
                    row.Cells[2].Value = h.Telek;
                    row.Cells[3].Value = h.Szint;
                }
                row.Cells[4].Value = el.Vevo;
                row.Cells[5].Value = el.EladasiAr;
                dgvEladasok.Rows.Add(row);
            }
        }

        private void Beolvas()
        {
            if (File.Exists("Eladasok.txt"))
            {
                StreamReader r = new StreamReader("Eladasok.txt");
                while (r.EndOfStream)
                {
                    Lakas l;
                    Eladas el;
                    string[] s = r.ReadLine().Split(';');
                    if (s.Length == 8)
                    {
                        l = new Lakas(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToBoolean(s[5]));
                        el = new Eladas(l, s[6], Convert.ToInt32(s[7]));
                    }
                    else
                    {
                        l = new Haz(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToInt32(s[6]), Convert.ToBoolean(s[7]));
                        el = new Eladas(l, s[8], Convert.ToInt32(s[9]));
                    }
                    eladasok.Add(el);
                }
                r.Close();
            }
        }
    }
}
