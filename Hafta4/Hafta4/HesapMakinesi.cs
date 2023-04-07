using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4
{
    public partial class HesapMakinesi : Form
    {
        islemler islemler = new islemler();

        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = islemler.topla(Convert.ToDouble(textBox1.Text) , Convert.ToDouble(textBox2.Text));
            label4.Text = sonuc.ToString();
        }

        private void HesapMakinesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Visible = true;

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sonuc = islemler.cıkar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label4.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sonuc = islemler.carp(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label4.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sonuc = islemler.bol(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label4.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sonuc = islemler.modAl(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            label4.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            if(comboBox1.SelectedItem.ToString().Equals("Topla"))
            {
                sonuc = islemler.topla(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Çıkar"))
            {
                sonuc = islemler.cıkar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Çarp"))
            {
                sonuc = islemler.carp(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Böl"))
            {
                sonuc = islemler.bol(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Mod Al"))
            {
                sonuc = islemler.modAl(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            }

            label4.Text = sonuc.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sonuc = 0;
            if (comboBox1.SelectedItem.ToString().Equals("Topla"))
            {
                sonuc = islemler.topla(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                listBox1.Items.Add(textBox1.Text + " + " + textBox2.Text + " = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + " + " + textBox2.Text + " = " + sonuc.ToString() + "\r\n");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Çıkar"))
            {
                sonuc = islemler.cıkar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                listBox1.Items.Add(textBox1.Text + " - " + textBox2.Text + " = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + " - " + textBox2.Text + " = " + sonuc.ToString() + "\r\n");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Çarp"))
            {
                sonuc = islemler.carp(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                listBox1.Items.Add(textBox1.Text + " * " + textBox2.Text + " = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + " * " + textBox2.Text + " = " + sonuc.ToString() + "\r\n");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Böl"))
            {
                sonuc = islemler.bol(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                listBox1.Items.Add(textBox1.Text + " / " + textBox2.Text + " = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + " / " + textBox2.Text + " = " + sonuc.ToString() + "\r\n");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Mod Al"))
            {
                sonuc = islemler.modAl(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                listBox1.Items.Add(textBox1.Text + " % " + textBox2.Text + " = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + " % " + textBox2.Text + " = " + sonuc.ToString() + "\r\n");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Karekök"))
            {
                sonuc = islemler.karekok(Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(textBox1.Text + " karekökü = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + "karekökü = " + sonuc.ToString() + "\r\n");
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Küpkök"))
            {
                sonuc = islemler.kupkok(Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(textBox1.Text + " küpkökü = " + sonuc.ToString());
                textBox3.AppendText(textBox1.Text + "karekökü = " + sonuc.ToString() + "\r\n");
            }
            sonuc = Math.Round(sonuc, 2);

            label4.Text = sonuc.ToString();
        }

        private void HesapMakinesi_Load(object sender, EventArgs e)
        {

        }
    }
}
