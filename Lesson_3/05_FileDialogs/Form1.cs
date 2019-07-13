using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_FileDialogs
{
    public partial class Form1 : Form
    {
        List<string> ukrainRegions;
        List<string> polandRegions;
        Product p;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new [] { "Україна", "Польща", "Литва", "Болгарія" });
            ukrainRegions = new List<string>
            {
                "Рівненська","Хмельницька","Житомирська","Київська","Одеська"
            };
            polandRegions = new List<string>
            {
                "Varshava region","Vroclav"
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            p = new Product
            {
                Category = textBox2.Text,
                Name = textBox1.Text,
                Price = (int)numericUpDown1.Value
            };
            listBox1.Items.Add(p);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           p =  (Product)listBox1.SelectedItem;
           label1.Text = p.Category + "   " + p.Name + "  " + p.Price.ToString();
            pictureBox1.Image = Image.FromFile(p.ImagePath);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem)
            {
                case "Україна":
                    {
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(ukrainRegions.ToArray());
                        break;
                    }
                case "Польща":
                    {
                        comboBox2.Items.Clear();
                        comboBox2.Items.AddRange(polandRegions.ToArray());
                        break;
                    }
                case "Литва":
                    {
                        break;
                    }
                case "Болгарія":
                    {
                        break;
                    }
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            DialogResult res =  openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
               p.ImagePath = openFileDialog1.FileName;
                MessageBox.Show(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if ( saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string newFile = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(newFile))
                {
                    sw.WriteLine(textBox3.Text);
                }
                MessageBox.Show("Saved");
            }
        }
    }
}
