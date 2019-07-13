using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_dateTimePicker_TrackBar
{
    public partial class Form1 : Form
    {
        int R = 0;
        int G = 0;
        int B = 0;
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.SelectionStart = DateTime.Now.AddDays(2);
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(7);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var date = monthCalendar1.SelectionRange.Start;
            label1.Text = date.ToLongDateString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            R = trackBar2.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            G = trackBar4.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
            pictureBox1.BackColor = Color.FromArgb(R, G, B);
        }
    }
}
