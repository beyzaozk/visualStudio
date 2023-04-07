using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta5
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        String[] dizi = new String[5];
        int ind = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (ind < dizi.Length) 
             {
                 if(textBox1.Text.Length == 0)
                     MessageBox.Show(" boş eleman eklenemez ", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                 else 
                 { 
                     dizi[ind] = textBox1.Text;
                     label1.ForeColor = Color.Green;
                     label1.Text = textBox1.Text + " diziye eklendi.";
                     ind++;
                 }
             }

             else
             {
                 label1.Text = textBox1.Text + " diziye eklenemedi.";
                 label1.ForeColor = Color.Red;
                 MessageBox.Show("dizi doldu", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

             }*/

            if (ind < Convert.ToInt32(comboBox1.SelectedItem.ToString()))
            {
                if (textBox1.Text.Length == 0)
                    MessageBox.Show(" boş eleman eklenemez ", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                else
                {
                    list.Add(textBox1.Text);
                    ind++;

                    label1.ForeColor = Color.Green;
                    label1.Text = textBox1.Text + " projeye eklendi.";
                }

            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = textBox1.Text + " projeye eklenemedi.";
                MessageBox.Show(" Personel sayısı doldu ", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }       

            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            /*for(int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] != null)
                listBox1.Items.Add(dizi[i]);
            }*/

            foreach (var eleman in list)
                listBox1.Items.Add(eleman);

            /*for (int i = 0; i < list.Count; i++)
            {
                listBox1.Items.Add(list[i]);
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                comboBox1.Items.Add((i + 1).ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*dizi = new String[5];
            ind = 0;*/

            list.Clear();
            ind = 0;
            listBox1.Items.Clear();
            comboBox1.Enabled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color; */

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                button2.BackColor = colorDialog1.Color;
                button3.BackColor = colorDialog1.Color;
                button4.BackColor = colorDialog1.Color;
                button5.BackColor = colorDialog1.Color;
                button6.BackColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            listBox1.BackColor = colorDialog1.Color;
            comboBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
