using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_2_ListView
{
    public partial class Form1 : Form
    {
        ListView lw;
        ImageList il;
        int yMove = +2;
        int merge = 30;
        int yLocationPopUp = -300;
        string path;// = @"D:\ШАГ\forms\ПрикладиЗКласу\WinForm\32ПР\07_ListView_ImgList\img\";
        string initalDir;// = @"D:\ШАГ\forms\ПрикладиЗКласу\WinForm\32ПР\07_ListView_ImgList\img\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(390, yLocationPopUp);

            string fullPathToExe = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
            string imgDir = Path.Combine(Directory.GetParent(fullPathToExe).Parent.Parent.FullName, @"img\");
            path = imgDir;
            initalDir = imgDir;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lw = new ListView();
            lw.Location = new Point(20, 20);
            lw.Size = new Size(360, 220);
            lw.View = View.List;
            lw.GridLines = true;
            lw.FullRowSelect = true;
            lw.MouseClick += Lw_MouseClick;
            lw.DoubleClick += Lw_DoubleClick;

            //--------------CREATE IMAGE LIST--------------
            il = new ImageList();
            il.Images.Add(Image.FromFile(path + "1.png"));
            il.Images.Add(new Bitmap(path + "2.png"));
            il.Images.Add(new Bitmap(path + "3.png"));
            //il.Images.Add(new Bitmap(path + "4.png"));
            //il.Images.Add(new Bitmap(path + "5.png"));
            il.ImageSize = new Size(50, 50);
            il.ColorDepth = ColorDepth.Depth32Bit;

            lw.LargeImageList = il;
            lw.SmallImageList = il;

            lw.Columns.Add("Language", 100);
            lw.Columns.Add("Topic", 100);
            lw.Columns.Add("Hours", 100);
            //--------------------CREATE ITEMS----------------
            ListViewItem item1 = new ListViewItem("MySql", 0);
            item1.SubItems.Add("Programming");
            item1.SubItems.Add("16");
            lw.Items.Add(item1);
            ListViewItem item2 = new ListViewItem("HTML", 1);
            item2.SubItems.Add("Programming");
            item2.SubItems.Add("20");
            lw.Items.Add(item2);
            ListViewItem item3 = new ListViewItem("PHP", 2);
            item3.SubItems.Add("Programming");
            item3.SubItems.Add("25");
            lw.Items.Add(item3);




            this.Controls.Add(lw);


          


        }

        private void Lw_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Lw_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem sel = lw.SelectedItems[0];
           if (e.Button == MouseButtons.Right)
            {
                lw.Items.Remove(sel);
            }
            else
            {
                ListViewItem copy = (ListViewItem)sel.Clone();
                lw.Items.Add(copy);
            }
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            if (btn.Checked == true)
            {
                switch(btn.Text)
                {
                    case "List":
                        lw.View = View.List;
                        break;
                    case "Tile":
                        lw.View = View.Tile;
                        break;
                    case "LargeIcon":
                        lw.View = View.LargeIcon;
                        break;
                    case "SmallIcon":
                        lw.View = View.SmallIcon;
                        break;
                    case "Details":
                        lw.View = View.Details;
                        break;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, this.Height);
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(430, yLocationPopUp);
            yLocationPopUp += yMove;
            if (merge > 0 && yLocationPopUp > merge) timer2.Stop();
            if (merge < 0 && yLocationPopUp < merge) timer2.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = initalDir;
            openFileDialog1.Filter = @"*.png|*.png";
            if ( openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                Image iimg = new Bitmap(filename);
                il.Images.Add(iimg);
                pictureBox1.Image = iimg;
                ListViewItem item = new ListViewItem("new item", il.Images.Count - 1);
                item.SubItems.Add("Programming");
                item.SubItems.Add("13");
                lw.Items.Add(item);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            merge = -300;
            yMove = -2;
            timer2.Start();
        }
    }
}
