using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Path
{
    public partial class Form1 : Form
    {
            GraphicsPath path2 = new GraphicsPath();
        public Form1()
        {
            InitializeComponent();
            Graphics g = CreateGraphics();
            Rectangle r = this.ClientRectangle;

            GraphicsPath path = new GraphicsPath();
            path.AddPie(r, 50, 50);
            this.Region = new Region(path);

            this.BackColor = Color.DarkRed;


            Rectangle bRect = button1.ClientRectangle;
            bRect.Inflate(-5, -5);
            path.AddEllipse(bRect);
            button1.Region = new Region(path);
            button1.FlatStyle = FlatStyle.Popup;
            button1.BackColor = Color.Red;
            button1.Click += Button1_Click;
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;



        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            path2.Reset();
            button1.BackColor = Color.Pink;
            Rectangle bRect = button1.ClientRectangle;
            bRect.Inflate(-5, -5);
            button1.FlatStyle = FlatStyle.Popup;
            path2.AddEllipse(bRect);
            button1.Region = new Region(path2);
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            path2.Reset();
            button1.BackColor = Color.Red;
            Rectangle bRect = button1.ClientRectangle;
            bRect.Inflate(-2, -2);
            button1.FlatStyle = FlatStyle.Popup;
            path2.AddEllipse(bRect);
            button1.Region = new Region(path2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Graphics g = CreateGraphics();
            //GraphicsPath gp = new GraphicsPath();
            //gp.AddString("Xdgsdgsgdsgs", new FontFamily("Times New Roman"),
            //      (int)(FontStyle.Bold | FontStyle.Italic),
            //      40, new Point(5, 5), StringFormat.GenericTypographic);
            //g.FillPath(Brushes.Black, gp);
            //gp.Dispose();
        }
    }
}
