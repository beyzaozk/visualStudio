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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string ad)
        {
            InitializeComponent();

            textBoxkadi.Text = ad;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*Random rnd = new Random();  
            int renk1 = rnd.Next(0, 255);
            int renk2 = rnd.Next(0, 255);
            int renk3 = rnd.Next(0, 255);

            this.BackColor = Color.FromArgb(renk1, renk2, renk3);

            renk1 = rnd.Next(0, 255);
            renk2 = rnd.Next(0, 255);
            renk3 = rnd.Next(0, 255);
            button1.BackColor = Color.FromArgb(renk1, renk2,renk3);

            button1.Font = new Font(button1.Font.FontFamily, button1.Font.Size +2);*/

            if ((textBoxkadi.Text == "admin") && (textBoxsifre.Text == "123456"))
            {
                this.Visible = false;

                Form2 form2 = new Form2(textBoxkadi.Text);
                form2.Show();
            }
            else if ((textBoxkadi.Text == "stok") && (textBoxsifre.Text == "1234"))
            {
                this.Visible = false;

                Form2 form2 = new Form2(textBoxkadi.Text);
                form2.Show();
            }
            else if ((textBoxkadi.Text == "") && (textBoxsifre.Text == ""))
                MessageBox.Show("kullanıcı adın veya şifre giriniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("kullanıcı adınız veya şifreniz yanlış", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        
    }
}
