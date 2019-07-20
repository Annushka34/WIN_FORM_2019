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

namespace _01_FormDialogue
{
    public partial class Form1 : Form
    {
        string filename = String.Empty;
        public Form1()
        {
            InitializeComponent();
            object[] arr = new object[] { 12, 14, 16, 18, 20, 22, 24 };
            comboBox1.Items.AddRange(arr);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "*.txt|*.txt";
           openFileDialog1.InitialDirectory = @"D:\STEP";
           var res =  openFileDialog1.ShowDialog();

            if (res == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    using (var fr = new StreamReader(fs))
                    {
                        textBox1.Text =  fr.ReadToEnd();
                    }
                }
            }
        }
        //--btn save as
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.txt|*.txt";
            if ( saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    using (var fw = new StreamWriter(fs))
                    {
                        fw.Write(textBox1.Text);
                    }
                }
            }
        }
        //---btn save
        private void button1_Click(object sender, EventArgs e)
        {
            if (filename != String.Empty)
            {
                using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    using (var fw = new StreamWriter(fs))
                    {
                        fw.Write(textBox1.Text);
                    }
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(oldFont, FontStyle.Bold);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font oldFont = richTextBox1.SelectionFont;
            richTextBox1.SelectionFont = new Font(oldFont.FontFamily, (int)comboBox1.SelectedItem );
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            btnColor_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnFont_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename != String.Empty)
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.RichText);
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Click save as");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.rtf|*.rtf";
            openFileDialog1.InitialDirectory = @"D:\STEP";
            var res = openFileDialog1.ShowDialog();
            //---if you need to check extention of a file----
            //FileInfo file = new FileInfo(filename);
            //if (file.Extension  == ?? ){}

            if (res == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(filename, RichTextBoxStreamType.RichText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.rtf|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Saved");
            }
        }
    }
}
