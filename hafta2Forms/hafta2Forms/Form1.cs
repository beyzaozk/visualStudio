﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2Forms
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldiniz";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Butona tıkladınız","uyarı",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }
    }
}
