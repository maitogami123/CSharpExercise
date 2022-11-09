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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataReader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlString = "Data Source=SAPLING\\SAPLING;Initial Catalog=Quanlysinhvien;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlString);
            conn.Open();


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from SinhVien";
            sqlCmd.Connection = conn;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string mssv = reader.GetInt32(0).ToString();
                string hoten = reader.GetString(1);
                string diachi = reader["DiaChi"].ToString();
                ListViewItem lv = new ListViewItem(mssv);
                lv.SubItems.Add(hoten);
                lv.SubItems.Add(diachi);
                listView1.Items.Add(lv);
            }
        }
    }
}
