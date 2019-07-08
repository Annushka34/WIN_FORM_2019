using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Opasity_Timer_ProgrBar
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (this.Width < 820)
            //{
            //    this.Width += 50;

            //}
            //else timer1.Stop();

            if (progressBar1.Value < progressBar1.Maximum)
                progressBar1.Value += 1;
            else timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.01)
                this.Opacity = this.Opacity * 0.95;
            else this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            btnFly.Scale(0.9f);
           //  btnFly.Location = new Point(200, 100);
           //  btnFly.Width = 200;
           //  btnFly.Height = 100;
            if (btnFly.Width < 1)
            {
                btnFly.Visible = false;
                timer3.Stop();
            }

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Text = textBox2.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //--add checking is empty field
            products.Add(new Product
            {
                Category = txtCateg.Text,
                Name = txtName.Text,
                Price = (double)numericUpDown1.Value,
                IsFreeShiping = checkBox1.Checked
            });
            progressBar1.Value += 1;
            textBox1.Text = "";
            foreach (var item in products)
            {
                textBox1.Text += item;
            }
        }
    }
}
