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

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font, FontStyle.Underline);
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font, FontStyle.Regular);
        }

        private void manjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font.FontFamily, lblText.Font.Size - 1);
        }

        private void većeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblText.Font = new Font(lblText.Font.FontFamily, lblText.Font.Size + 1);
        }
    }
}
