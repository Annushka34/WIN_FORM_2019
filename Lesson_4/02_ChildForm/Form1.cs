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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var budjet = numericUpDown1.Value;
            //Form2 childForm = new Form2(budjet);
            //childForm.SetDate = DateTime.Now;
            //childForm.Show("Olga");

            Form2 childForm = new Form2(this);
            childForm.SetDate = DateTime.Now;
            childForm.Show("Olga");
            btnOpen.Hide();

          //  this.Hide();
        }
    }
}
