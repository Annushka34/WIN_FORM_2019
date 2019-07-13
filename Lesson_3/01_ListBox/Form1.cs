using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _01_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = @"insert into [User] Values ('Vasja')";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();

            query = @"select * from [User]";
            com = new SqlCommand(query, con);
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();

            label1.Text = reader[0] + "   " + reader[1];
            reader.Read();

            label2.Text = reader[0] + "   " + reader[1];
            reader.Close();

            con.Close();


            listBox1.Items.Add("ковбаса");
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>
            {
                "Олена","Василь","Петро","Іван","Махмед"
            };
            listBox2.DataSource = list;
        }
    }
}
