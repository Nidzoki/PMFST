using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak4
{
    public partial class Form2 : Form
    {

        public string recenica;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKraj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblText.Text = recenica;
        }
    }
}
