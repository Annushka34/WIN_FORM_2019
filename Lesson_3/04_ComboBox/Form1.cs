using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_ComboBox
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> products;
        public Form1()
        {
            InitializeComponent();
            products = new Dictionary<string, List<string>>
            {
                {"молочні", new List<string>{"молоко", "сир","масло","йогурт" } },
                {"хлібо-булочні", new List<string>{ "хліб","батон","печиво"} }
            };      
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                var listVals = products.Where(x => x.Key == comboBox1.SelectedItem).SelectMany(x => x.Value).ToList();
                comboBox2.DataSource = listVals;
                label1.Text = comboBox1.SelectedItem.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            DateTime zeroTime = new DateTime(1, 1, 1);
            int years = (zeroTime + (DateTime.Now - birthday)).Year - 1;
            label1.Text = years.ToString();
        }
    }
}
