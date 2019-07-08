using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_ListBox_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label1.Text = checkBox1.Text;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label1.Text = checkBox2.Text;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label1.Text = checkBox3.Text;
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //if ((sender as  CheckBox).Checked)
            //label2.Text = (sender as CheckBox).Text;
            label2.Text = "";
            foreach (var item in groupBox1.Controls)
            {
                if (item is CheckBox)
                {
                    if ((item as CheckBox).Checked)
                    label2.Text += (item as CheckBox).Text+ "   ";
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                (sender as CheckBox).BackColor = Color.Gray;
                //   hhow to know what buttons is selected&
                foreach( var item in this.Controls)
                {
                    if (item is Button)
                    {
                        if ((item as Button).Enabled == false)
                        {
                            textBox1.Text += (item as Button).Text + " ";
                        }
                    }
                }


            }
            else
                (sender as CheckBox).BackColor = Color.Pink;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            (sender as Button).BackColor = Color.Gray;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = 0;
            int y = 0;
            int amount = r.Next(5, 15);
            for (int i = 0; i < amount; i++)
            {
                Button b = new Button() { Text = i.ToString() };
                b.SetBounds(5+x*55, 5 + 55* y, 50, 50);
                b.Click += B_Click;

                label3.Controls.Add(b);
                x++;
                if (x % 8 == 0)
                {
                    x = 0;
                    y++;
                }
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Pink;
        }
    }
}
