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
    public partial class Form1 : Form
    {
        List<Lakas> lakasok = new List<Lakas> ();
        public Form1()
        {
            InitializeComponent();
            Beolvas();
        }

        private void Beolvas()
        {
            if (File.Exists("Lakasok.txt"))
            {
                StreamReader r = new StreamReader("Lakasok.txt");
                while (!r.EndOfStream)
                {
                    Lakas l;
                    string[] s = r.ReadLine().Split(';');
                    if (s.Length == 6)
                    {
                        l = new Lakas(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToBoolean(s[5])); 
                    }
                    else
                    {
                        l = new Haz(s[0], s[1], Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToInt32(s[6]), Convert.ToBoolean(s[7]));
                    }
                    lakasok.Add(l);
                    lbIngatlanok.Items.Add(l.Azonosito + "\t" + l.Cim);
                }
                r.Close();
                Lakas.Szam = lakasok.Count;
            }
        }

        private void újIngatlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UjIngatlanForm uj = new UjIngatlanForm();
            if (uj.ShowDialog() == DialogResult.OK)
            {
                lakasok.Add(uj.L);
                lbIngatlanok.Items.Add(uj.L.Azonosito + "\t" + uj.L.Cim);

            } 

        }

        private void lbIngatlanok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kiir();           
        }

        private void érdeklődőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbIngatlanok.SelectedIndex >= 0)
            {
                Lakas l = lakasok[lbIngatlanok.SelectedIndex];
                if (!l.Eladva)
                {
                    ErdeklodesForm uj = new ErdeklodesForm(l);
                    if (uj.ShowDialog() == DialogResult.OK)
                    {
                        Kiir();
                        if (l.Eladva)
                        {
                            FileIras();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Az ingatlan értékesítve lett !");
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztva ingatlan !");
            }
        }

        private void FileIras()
        {
            if (File.Exists("Lakasok.txt"))
            {
                StreamWriter w = new StreamWriter("Lakasok.txt");
                {
                    foreach (Lakas l in lakasok)
                    {
                        w.WriteLine(l.ToString());
                    }
                }
                w.Close();
            }
        }

        private void Kiir()
        {
            if (lbIngatlanok.SelectedIndex >= 0)
            {
                tbAzon.Text = lakasok[lbIngatlanok.SelectedIndex].Azonosito;
                tbCim.Text = lakasok[lbIngatlanok.SelectedIndex].Cim;
                tbMeret.Text = lakasok[lbIngatlanok.SelectedIndex].Meret.ToString();
                tbAr.Text = lakasok[lbIngatlanok.SelectedIndex].Ar.ToString();
                tbErdeklodo.Text = lakasok[lbIngatlanok.SelectedIndex].Erdeklodok.ToString();
                if (lakasok[lbIngatlanok.SelectedIndex] is Haz)
                {
                    groupBox2.Visible = true;
                    Haz h = lakasok[lbIngatlanok.SelectedIndex] as Haz;
                    tbTelek.Text = h.Telek.ToString();
                    tbSzint.Text = h.Szint.ToString();
                }
                else
                {
                    groupBox2.Visible = false;
                }
                if (lakasok[lbIngatlanok.SelectedIndex].Eladva)
                {
                    labEladva.Visible = true;
                }
                else
                {
                    labEladva.Visible = false;
                }
            }
        }

        private void eladásokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EladasokForm uj = new EladasokForm();
            uj.ShowDialog();
        }
    }
}
