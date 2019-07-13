using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            //label1.Text = checkedListBox1.SelectedItem.ToString();
           foreach(var item in checkedListBox1.CheckedItems)
            {
                label1.Text += " - " + item.ToString();
            }
        }
    }
}
