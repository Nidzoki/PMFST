using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Alfa Romeo Giulietta");
            listBox1.Items.Add("Audi S8");
            listBox1.Items.Add("Ford Mondeo");
            listBox1.Items.Add("FIAT Panda");
            listBox1.Items.Add("Peugeot 308");
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
