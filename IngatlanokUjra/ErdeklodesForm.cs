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
    public partial class ErdeklodesForm : UjIngatlanForm
    {
        Lakas l;
        public ErdeklodesForm(Lakas lakas)
        {
            InitializeComponent();
            l = lakas;
            tbCim.Text = l.Cim;
            nudMeret.Value = l.Meret;
            nudAr.Value = l.Ar;
            if (l is Haz)
            {
                Haz h = l as Haz;
                rbHaz.Checked = true;
                this.rbHaz.Location = new System.Drawing.Point(38, 292);
                rbLakas.Visible = false;
                nudTelek.Value = h.Telek;
                nudSzint.Value = h.Szint;
            }
            else
            {
                rbHaz.Checked = false;
                rbLakas.Checked = true;
                groupBox2.Visible = false;

            }
        }

        private void rbErdeklodes_CheckedChanged(object sender, EventArgs e)
        {
            label7.Visible = !label7.Visible;
            nudEladasiAr.Visible = !nudEladasiAr.Visible;
        }

        protected override void Felvesz()
        {
            if (tbVevoNeve.Text != "")
            {
                if (rbErdeklodes.Checked)
                {
                    l.Erdeklodok++;
                }
                else
                {
                    l.Eladva = true;
                    Eladas el = new Eladas(l, tbVevoNeve.Text, Convert.ToInt32(nudEladasiAr.Value));
                    StreamWriter w = new StreamWriter("Eladasok.txt", true);
                    w.Write(el.ToString());
                    w.Close();
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Nem adta meg a vevő/érdeklődő nevét !");
            }
        }
    }
}
