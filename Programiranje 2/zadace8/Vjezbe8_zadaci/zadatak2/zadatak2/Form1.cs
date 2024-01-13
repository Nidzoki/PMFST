using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                label3.Text = (x + y).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešno upisane vrijednosti!","Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x, y;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                label3.Text = (x - y).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešno upisane vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x, y;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                label3.Text = (x * y).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešno upisane vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x, y;
            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y) && y != 0)
            {
                label3.Text = (x / y).ToString();
            }
            else
            {
                MessageBox.Show("Pogrešno upisane vrijednosti!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
