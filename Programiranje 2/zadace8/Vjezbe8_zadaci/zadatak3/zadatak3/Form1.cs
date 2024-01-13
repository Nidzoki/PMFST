using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;

            if (double.TryParse(textBox1.Text, out x1) && double.TryParse(textBox2.Text, out y1) && double.TryParse(textBox3.Text, out x2) && double.TryParse(textBox4.Text, out y2))
            {
                rezultat.Text = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)* (y2 - y1)).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešne vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
