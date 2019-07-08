using _02_Opasity_Timer_ProgrBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_DataPicker_Numeric
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            products.Add(new Product
            {
                Category = "Toys",
                Name = "Car",
                Price = 250,
                IsFreeShiping = true
            });

            dataGridView1.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products.Add(new Product
            {
                Category = textBox1.Text,
                Name = textBox1.Text,
                Price = (double)numericUpDown1.Value,
                IsFreeShiping = checkBox1.Checked
            });
        }
    }
}
