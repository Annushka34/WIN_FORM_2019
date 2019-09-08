using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Grathics_Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Italic | FontStyle.Bold);
            Brush brush = new SolidBrush(Color.Magenta);
           // StringFormat format = new StringFormat(StringFormatFlags.DirectionVertical);
            e.Graphics.DrawString("HELLO WORLD", font, brush, 10, 10);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(FontFamily.GenericMonospace, 6, FontStyle.Italic | FontStyle.Bold);
            Brush brush = new SolidBrush(Color.DarkMagenta);
            // StringFormat format = new StringFormat(StringFormatFlags.DirectionVertical);
            e.Graphics.DrawString("HELLO WORLD", font, brush, button1.Width - 70, 4);
        }
    }
}
