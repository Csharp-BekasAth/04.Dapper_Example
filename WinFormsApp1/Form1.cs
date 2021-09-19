using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-GO1MARS;Database=DapperExample;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            MessageBox.Show("Connected!");

            string sql = "SELECT ID,NAME,AFM FROM CUSTOMER";

            var lc = connection.Query<Customer>(sql);

            foreach(Customer c in lc)
            {
                listBox1.Items.Add(c.NAME);
            }

            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }
    }
}
