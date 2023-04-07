using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3
{
    public partial class Form2 : Form
    {
        private string ad1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string ad)
        {
            InitializeComponent();

            ad1 = ad;
            label1.Text = label1.Text + " " + ad;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1(ad1);
            form1.Visible = true;

            this.Dispose();

        }
    }
}
