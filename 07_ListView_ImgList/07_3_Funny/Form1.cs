using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_3_Funny
{
    public partial class Form1 : Form
    {
        double opacityVal = 1;
        int xLocationPopUp = 450;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.FromArgb(255, 180, 50);
          //  pictureBox2.BackColor = Color.FromArgb(255, 200, 50);
        //    pictureBox3.BackColor = Color.FromArgb(255, 200, 50);

            this.TransparencyKey = Color.FromArgb(255, 180, 50);
            groupBox1.Location = new Point(xLocationPopUp, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = opacityVal;
            opacityVal -= 0.01;
            if(opacityVal<0.1)
            {
                this.Close();
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {          
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(xLocationPopUp, 20);
            xLocationPopUp -= 2;
            if (xLocationPopUp < 150) timer2.Stop();
        }
    }
}
