using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_ToolStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ((Control)pictureBox1).AllowDrop = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.DragDrop += PictureBox1_DragDrop;
        }

        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var file = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileInfo f = new FileInfo(file[0]);
            Image img = new Bitmap(f.FullName);

            pictureBox1.Image = img;
            PictureBox newP = new PictureBox();
            newP.SizeMode = PictureBoxSizeMode.Zoom;
            newP.SetBounds(100, 100, 300, 300);
            ((Control)newP).AllowDrop = true;
            this.Controls.Add(newP);
            newP.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem item = new ToolStripMenuItem("111") { Checked = false, CheckOnClick = true };
            item.DropDownItems.Add(new ToolStripMenuItem("*") { CheckOnClick = true, ShortcutKeys = Keys.A | Keys.Control });
            item.DropDownItems.Add("+");
            menuStrip1.Items.Add(item);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                foreach (ToolStripMenuItem m in item.DropDownItems)
                {
                    if (m.CheckState == CheckState.Checked)
                    {
                        MessageBox.Show(m.Text);
                    }

                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = "!!!";
            object file = e.Data.GetData(DataFormats.FileDrop);
            FileInfo f = new FileInfo(((string[])file)[0]);
            StreamReader sr = new StreamReader(f.FullName);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBox1_DragLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            pictureBox1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
    }
}
