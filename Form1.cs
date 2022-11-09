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

namespace DataReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlString = "Data Source=SAPLING\\SAPLING;Initial Catalog=Quanlysinhvien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlString);
            conn.Open();
            string maSV = textBox1.Text.Trim();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from SinhVien where MaSo= '" + maSV + "'";
            sqlCmd.Connection = conn;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read()) {
                textBox2.Text = reader["HoTen"].ToString();
                textBox3.Text = reader["DiaChi"].ToString();
            }
        }
    }
}
