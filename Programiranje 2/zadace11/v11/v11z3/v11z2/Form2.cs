using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v11z2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Student student;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && numericUpDown1.Value < 2024)
            {
                student.Ime = textBox1.Text;
                student.Prezime = textBox2.Text;
                student.Godina = ((int)numericUpDown1.Value);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nisu uneseni svi podaci!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
