using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ChildForm
{
    public partial class Form2 : Form
    {
        Form1 _parent;
        public Form2()
        {
            InitializeComponent();
        }
        //---case 1 - overload constructor---
        public Form2(decimal budjet)
        {
            InitializeComponent();
            label1.Text += "   "+budjet.ToString() + " grn you can visit the next places: ";
        }

        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Show(string name)
        {
            this.Show();
            label2.Text += name;
        }

        public DateTime SetDate { get; set; }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Close();
        }

   


        public void SetFocusTextBox ()
        {
            this.textBox1.Enabled = true;
            this.textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBox1.Enabled = false;
                _parent.SetFocusForm3();
            }
        }
    }
}
