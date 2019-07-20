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
        Form2 child2;
        Form3 child3;
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

            child2 = new Form2(this);
            child2.SetDate = DateTime.Now;
            child2.Show("Olga");
            child2.Location = new Point(100, 100);

            child3 = new Form3(this);
            child3.Show();
            //---!!!after show
            child3.Location = new Point(600, 100);

         //   btnOpen.Hide();

            this.Hide();
        }

        public void SetFocusForm2()
        {
            child2.SetFocusTextBox();
        }

        public void SetFocusForm3()
        {
            child3.SetFocusTextBox();
        }
    }
}
