using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2
{
    public partial class Form1 : Form
    {
        string pswd = "1234";

        public Form1()
        {
            InitializeComponent();
            lblInfo.Visible = false;
            lblInfo.Text = @"В квадратных скобках задается диапазон символов, которые должны в данном месте встречаться. В итоге данный и предыдущий шаблоны телефонного номера будут эквивалентны."+
"Также можно задать диапазон для алфавитных символов: Regex regex = new Regex( а что делать, если у нам надо найти, строки, где содержится точка, звездочка или какой - то другой специальный символ? В этом случае нам надо просто экранировать эти символы слешем: ";
            this.Width = 400;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

   

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Red;
        }

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Red;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Green;
        }

        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Test");
          //  this.Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Form1_KeyPress");
        }

        private void btnOk_MouseClick(object sender, MouseEventArgs e)
        {
            btnStart.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart.Visible = false;
        }

        static bool isPressed = false;
        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Text = isPressed ? "Wait" : "Runned";
            isPressed = !isPressed;
            lblState.Text = btnRun.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtStartText.ReadOnly = true;
        }

        private void txtStartText_TextChanged(object sender, EventArgs e)
        {
          //  lblState.Text = txtStartText.Text;
            if (txtStartText.Text.Contains("."))
            {
                lblState.Text = "Not valid";
                txtStartText.Text = txtStartText.Text.Replace('.', ' ');
            }
        }

        private void btnPhoneOk_Click(object sender, EventArgs e)
        {
            string pattern = @"^\d{3}-\d{2}-\d{2}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(txtPhone.Text))
            {
                lblPhone.Text = txtPhone.Text;
            }
        }

        private void btnPswd_Click(object sender, EventArgs e)
        {
            if (txtPswd.Text == pswd)
            {
                // this.Width = 930;
                timerSizeForm.Start();
             
            }
            else
                txtPswd.Text = "";
        }

        private void timerSizeForm_Tick(object sender, EventArgs e)
        {
            lblState.Text = this.Width.ToString();
            if (this.Width < 930)
                this.Width = this.Width + 25;
            else
            {
                timerSizeForm.Stop();
                lblInfo.Visible = true;
            }

        }
    }
}
