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
    public partial class UjIngatlanForm : Form
    {
        Lakas l;

        internal Lakas L { get => l; set => l = value; }

        public UjIngatlanForm()
        {
            InitializeComponent();
        }

        private void rbLakas_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = !groupBox2.Visible;
        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            Felvesz();
           
        }

        protected virtual void Felvesz()
        {
            if (tbCim.Text != "")
            {
                if (rbLakas.Checked)
                {
                    L = new Lakas(tbCim.Text, Convert.ToInt32(nudMeret.Value), Convert.ToInt32(nudAr.Value));
                }
                else
                {
                    L = new Haz(tbCim.Text, Convert.ToInt32(nudMeret.Value), Convert.ToInt32(nudAr.Value), Convert.ToInt32(nudTelek.Value), Convert.ToInt32(nudSzint.Value));
                }
                StreamWriter w = new StreamWriter("Lakasok.txt", true);
                w.WriteLine(L.ToString());
                w.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Hiányzó cím !");
            }
        }
    }
}
