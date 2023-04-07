using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hafta6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton c in panel1.Controls)
            {
                if (c.Checked == true)
                {
                    textBox1.Text = c.Text;
                    c.Checked = false;
                }

            }

            foreach (RadioButton c in panel2.Controls)
            {
                if (c.Checked == true)
                {
                    textBox2.Text = c.Text;
                    c.Checked = false;
                }

            }
        }
    }
}
