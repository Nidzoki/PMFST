using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string ispis = "";
            int god;
            if (txtIme.Text != "" && cmbPrebivaliste.SelectedIndex>= 0 && cmbPrebivaliste.SelectedIndex < cmbPrebivaliste.Items.Count && int.TryParse(txtGod.Text, out god) && god > 1900 && god <= 2023 && (radioM.Checked || radioZ.Checked))
            {
                if (radioM.Checked)
                {
                    ispis += "gospodin ";
                }
                else
                {
                    ispis += "gospođa ";
                }

                ispis += txtIme.Text + '\n';
                ispis += cmbPrebivaliste.SelectedItem.ToString() + '\n';
                ispis += txtGod.Text + '\n';

                if (chkA.Checked)
                {
                    ispis += "A ";
                }
                if (chkB.Checked)
                {
                    ispis += "B ";
                }
                if (chkC.Checked)
                {
                    ispis += "C ";
                }
                if (chkD.Checked)
                {
                    ispis += "D ";
                }


                lblIspis.Text = ispis;
            }
            else
            {
                MessageBox.Show("Greška pri unosu podataka!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
