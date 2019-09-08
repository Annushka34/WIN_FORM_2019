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

namespace _03_OwnProgressBar
{
    public partial class Form1 : Form
    {
        OwnProgressBar prB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prB = new OwnProgressBar();
            prB.Style = ProgressBarStyle.Continuous;
            timer1.Start();
            this.Controls.Add(prB);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prB.Value <prB.Maximum -1)
            prB.Value += prB.Step;
        }
    }

    public class OwnProgressBar : ProgressBar
    {
        public OwnProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;

            Brush brush = new LinearGradientBrush(rec, Color.FromArgb(255, 0, 0), Color.FromArgb(150, 0, 0), LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.Pink), 2, 2, rec.Width, rec.Height);
        }
    }
}
