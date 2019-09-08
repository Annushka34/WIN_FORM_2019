using _04_GrathicsImg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Img
{
    public partial class Form1 : Form
    {
        int plusInd = 2;
        int plusIndToSize = 100;
        int rot = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyButton b = new MyButton("SHOW NATIVE");
            b.SetBounds(10, this.Height - 120, 70, 50);
            Controls.Add(b);
            b.Click += B_Click;

            MyButton bPlus = new MyButton("+");
            bPlus.SetBounds(100, this.Height - 120, 70, 50);
            Controls.Add(bPlus);
            bPlus.Click += BPlus_Click;

            MyButton bReal = new MyButton("Show real");
            bReal.SetBounds(200, this.Height - 120, 70, 50);
            Controls.Add(bReal);
            bReal.Click += bReal_Click;

            MyButton sizeMin = new MyButton("MIN SIZE");
            sizeMin.SetBounds(300, this.Height - 120, 70, 50);
            Controls.Add(sizeMin);
            sizeMin.Click += sizeMin_Click;

            MyButton rotate = new MyButton("ROTATE");
            rotate.SetBounds(400, this.Height - 120, 70, 50);
            Controls.Add(rotate);
            rotate.Click += rotate_Click;

            MyButton diag = new MyButton("DIAGONALE");
            diag.SetBounds(500, this.Height - 120, 70, 50);
            Controls.Add(diag);
            diag.Click += diag_Click;
        }

        private void diag_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            Image img = new Bitmap(this.GetType(), "6.bmp");
            int width = 150;
            double ind = img.Width / img.Height;
            int height = (int)(width * ind);

            Point[] points =
             {
                new Point(10,10),
                new Point (100,rot),
                new Point (10,100)
            };
            rot += 10;
            // g.DrawImage(img, rect);
          //  g.RotateTransform(90);
            g.DrawImage(img, points);
        }

        private void rotate_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap(this.GetType(), "6.bmp");
            int width = 150;
            double ind = img.Width / img.Height;
            int height = (int)(width * ind);

            Rectangle rect = new Rectangle(100, -200, width, height);
           // g.DrawImage(img, rect);
            g.RotateTransform(90);
            g.DrawImage(img, rect);
        }

        private void sizeMin_Click(object sender, EventArgs e)
        {
            Image imgSource = new Bitmap(this.GetType(), "6.bmp");
            Image img =  new Bitmap(imgSource, imgSource.Width - plusIndToSize, imgSource.Height - plusIndToSize);
            plusIndToSize += 2;
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            int width = 150;
            double ind = img.Width / img.Height;
            int height = (int)(width * ind);
            Rectangle rect = new Rectangle(0, 0, width, height);
            Rectangle rectDest = new Rectangle(10, 10, width, height);

            g.DrawImage(img, rect, rectDest, GraphicsUnit.Pixel);//source - portion to draw, destination - where draw
        }

        private void bReal_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap(this.GetType(), "6.bmp");
            int width = 150;
            double ind = img.Width / img.Height;
            int height = (int)(width * ind);
            Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
            Rectangle rectDest = new Rectangle(10, 10, width, height);

            g.DrawImage(img, rect, rectDest, GraphicsUnit.Pixel);//source - portion to draw, destination - where draw
        }

        private void BPlus_Click(object sender, EventArgs e)
        {            
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Image img = new Bitmap(this.GetType(), "6.bmp");
            int width = 150;
            double ind = img.Width / img.Height;
            int height = (int)(width * ind);
            Rectangle rect = new Rectangle(10, 10, width+plusInd, height+plusInd);
            plusInd += 2;
            g.DrawImage(img, rect);
        }

        private void B_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Image img = new Bitmap(this.GetType(), "6.bmp");
            int width = 150;
            double ind = img.Width / img.Height;
            int height = (int)(width * ind);
            Rectangle rect = new Rectangle(10, 10, width, height);
            g.DrawImage(img, rect);

        }
    }
}
