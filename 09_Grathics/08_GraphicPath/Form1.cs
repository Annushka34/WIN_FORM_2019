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

namespace _08_GraphicPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(Brushes.Red, this.ClientRectangle);

            GraphicsPath gp = new GraphicsPath();
            gp.AddString("hello world", new FontFamily("Times New Roman"),
                  (int)(FontStyle.Bold | FontStyle.Italic),
                  40, new Point(5, 5), StringFormat.GenericTypographic);
            g.FillPath(Brushes.Black, gp);
            gp.Dispose();
        }
        const int shadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.ClassStyle = shadow;
                return p;
            }
        }
    }
}
