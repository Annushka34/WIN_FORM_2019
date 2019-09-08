using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           var gr = e.Graphics;///---3

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();//---1



            Pen p = new Pen(Color.AliceBlue);
            p.Width = 5;
            Rectangle r = this.DisplayRectangle;
            r.Inflate(-20, -20);
            g.DrawEllipse(p, r);
            p.Dispose();
            g.Dispose();



            Graphics btnG = button1.CreateGraphics();//===2
            Rectangle r1 = button1.DisplayRectangle;
            r1.Inflate(-1, -1);
            Brush b = new SolidBrush(Color.BlueViolet);
            btnG.FillEllipse(b, r1);


            btnG.DrawString("Press me", new Font(FontFamily.GenericMonospace, 12f, FontStyle.Italic), new SolidBrush(Color.Blue), 10, 10);

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Graphics btnG = button1.CreateGraphics();//===2
            btnG.DrawString("Press me", new Font(FontFamily.GenericMonospace, 12f, FontStyle.Italic), new SolidBrush(Color.Blue), 10, 10);
        }
    }
}
