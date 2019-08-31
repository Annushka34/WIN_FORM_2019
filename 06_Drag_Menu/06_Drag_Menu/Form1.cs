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

namespace _06_Drag_Menu
{
    public partial class Form1 : Form
    {

        string imgInMemory = "";
        public Form1()
        {
            InitializeComponent();
            ((Control)pictureBox2).AllowDrop = true;
            ((Control)pictureBox2).DragDrop += Form1_DragDrop;
            ((Control)pictureBox2).DragEnter += textBox1_DragEnter;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add(new ToolStripMenuItem("+") { CheckOnClick = true});
            menu.Items.Add(new ToolStripMenuItem("-") { CheckOnClick = true });
            menu.Items.Add(new ToolStripMenuItem("/") { CheckOnClick = true });
            menu.Items.Add(new ToolStripMenuItem("*") { CheckOnClick = true });
            textBox1.ContextMenuStrip = menu;
            timer1.Start();

            pictureBox1.Image = Image.FromFile("D:/2.jpg");
            pictureBox3.Image = Image.FromFile("D:/1.jpg");
        }


        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //  string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            // string filename = data[0];
            //  pictureBox1.Image = Image.FromFile(filename);

            pictureBox1.Image = Image.FromFile(imgInMemory);
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            string filename = data[0];

          //  textBox1.Text = filename;
            using (StreamReader sr = new StreamReader(filename))
            {
                textBox1.Text = sr.ReadToEnd();
            }
            label1.Text = (new FileInfo(filename)).Name;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveAsToolStripMenuItem.CheckState == CheckState.Checked)
                saveAsToolStripMenuItem.Image = Image.FromFile(@"D:\ШАГ\forms\ПрикладиЗКласу\WinForm\32ПР\06_Drag_Menu\1.jpg");
            else
                saveAsToolStripMenuItem.Image = Image.FromFile(@"D:\ШАГ\forms\ПрикладиЗКласу\WinForm\32ПР\06_Drag_Menu\2.jpg");
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(txtSearch.Text) { CheckOnClick = true };
                item.ShortcutKeys = Keys.Control |Keys.B;
                item.Click += Item_Click;
                historyDropDown.DropDownItems.Add(item);
                txtSearch.Text = "";
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //---CASE 1
            foreach (ToolStripMenuItem item in historyDropDown.DropDownItems)
            {
                if (item.CheckState == CheckState.Checked)
                    textBox1.Text += item.Text;
            }
            //---CASE 2
            //ToolStripMenuItem checkedItem = (sender as ToolStripMenuItem);
            //foreach (ToolStripMenuItem item in historyDropDown.DropDownItems)
            //{
            //    if (item != checkedItem)
            //    item.Checked = false;
            //}
            //if (checkedItem.CheckState == CheckState.Checked)
            //     textBox1.Text += checkedItem.Text;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txtSearch.Width =  (int)(this.Width * 0.5);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            txtSearch.Width = (int)(this.Width * 0.5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imgInMemory = pictureBox2.ImageLocation;
        }
    }
}
