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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if (checkBox1.Checked == true)
               {
                   listBox1.Items.Add(checkBox1.Text);
               }
               if (checkBox2.Checked == true)
               {
                   listBox1.Items.Add(checkBox2.Text);
               }
               if (checkBox3.Checked == true)
               {
                   listBox1.Items.Add(checkBox3.Text);
               }

               checkBox1.Checked = false;
               checkBox2.Checked = false;
               checkBox3.Checked = false;  */

          /*foreach (var item in checkedListBox1.CheckedItems)
            {
                bool flag = false;
                foreach (var lstitem in listBox1.Items)
                {
                    if (item.ToString().Equals(lstitem.ToString()))
                    {
                        flag = true; 
                        break;
                    }
                }
                if(flag == false)
                    listBox1.Items.Add(item.ToString());
                
            }

            foreach (int ind in checkedListBox1.CheckedIndices)
                checkedListBox1.SetItemCheckState(ind, CheckState.Unchecked);  */

            foreach (RadioButton c in groupBox1.Controls)
            {
                if(c.Checked == true)
                {
                    listBox1.Items.Add(c.Text);
                    c.Checked = false;
                }
                    
            }
            groupBox1.Enabled = true;

            foreach (RadioButton c in groupBox2.Controls)
            {
                if (c.Checked == true)
                {
                    listBox1.Items.Add(c.Text);
                    c.Checked = false;
                }

            }
            groupBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
            }
            else
                MessageBox.Show("listboxdan değer seçiniz.", "hata", MessageBoxButtons.OKCancel);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.Show();
        }
    }
}
