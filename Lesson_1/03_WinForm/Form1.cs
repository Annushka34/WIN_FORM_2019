using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "My first form";

            Button btn = new Button();
            btn.Text = "No";
            btn.Location = new Point(150, 200);
            this.Controls.Add(btn);
            btn.Click += button1_Click;

            Button btn2 = new Button();
            btn2.Text = "Cansel";
            btn2.Location = new Point(250, 200);
            this.Controls.Add(btn2);
            btn2.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btn_OK.BackColor = Color.Red;
            (sender as Button).BackColor = Color.Red;
            //((Button)sender).BackColor = Color.Red;
            label1.Text = (sender as Button).Text;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = new Point(btn_OK.Location.X - 10, btn_OK.Location.Y - 10);
            Rectangle rectangle = new Rectangle(p, new Size(btn_OK.Width + 20, btn_OK.Height + 20));
            if (rectangle.Contains(e.Location))
            {
                MessageBox.Show("You enter this area");
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            b.Width = 70;
            b.Height = 70;
            b.BackColor = Color.Green;
            b.Text = "+";
            b.Location = e.Location;
            b.Click += B_Click;
            this.Controls.Add(b);
        }

        private void B_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as Button);
        }
    }
}
