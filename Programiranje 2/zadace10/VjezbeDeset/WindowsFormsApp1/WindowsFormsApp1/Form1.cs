using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOdredi_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string poruka = "";
            if (!double.TryParse(txtA.Text, out a) || a == 0)
            {
                poruka += "A ";
            }
            if (!double.TryParse(txtB.Text, out b))
            {
                poruka += "B ";
            }
            if (!double.TryParse(txtC.Text, out c))
            {
                poruka += "C ";
            }

            if (poruka != "")
            {
                MessageBox.Show($"Pogrešan unos {poruka}!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
