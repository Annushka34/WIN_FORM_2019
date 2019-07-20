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
    public partial class Form3 : Form
    {
        Form1 _parent;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Form1 form1)
        {
            InitializeComponent();
            _parent = form1;
        }

  

        public void SetFocusTextBox()
        {
            this.textBox1.Enabled = true;
            this.textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                this.textBox1.Enabled = false;
                _parent.SetFocusForm2();
            }
        }
    }
}
