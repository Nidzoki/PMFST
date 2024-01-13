using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v11z1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            double c;
            if (txtIme.Text != "" && double.TryParse(txtCijena.Text, out c) && c >= 0 && cmbVrsta.SelectedIndex >= 0 && cmbVrsta.SelectedIndex < 3)
            {
                Dostava nova = new Dostava(txtIme.Text,cmbVrsta.Text, c);

                dostava = nova;
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška pri unosu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Dostava dostava;
    }
}
