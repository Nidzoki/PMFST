using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pdv, cijena;
            if (double.TryParse(textBox2.Text, out cijena) && double.TryParse(textBox3.Text, out pdv) && pdv >= 0 && pdv <= 100 && cijena >= 0)
            {
                textBox4.Text = (cijena * pdv / 100).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešno upisane vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pdv, stopa;
            if (double.TryParse(textBox3.Text, out stopa) && double.TryParse(textBox4.Text, out pdv) && stopa >= 0 && stopa <= 100 && pdv >= 0)
            {
                textBox2.Text = (100 * pdv / stopa).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešno upisane vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
