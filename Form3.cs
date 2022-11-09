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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
            
            string sqlString = "Data Source=SAPLING\\SAPLING;Initial Catalog=Quanlybanhang;Integrated Security=True";
            
            SqlConnection conn = new SqlConnection(sqlString);
            conn.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from NhaCC";
            sqlCmd.Connection = conn;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader["MaNCC"].ToString());
                lv.SubItems.Add(reader["TenNCC"].ToString());
                lv.SubItems.Add(reader["DiaChi"].ToString());
                lv.SubItems.Add(reader["DienThoai"].ToString());
                listView1.Items.Add(lv);
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlString = "Data Source=SAPLING\\SAPLING;Initial Catalog=Quanlybanhang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(sqlString);
            conn.Open();

            listView2.Items.Clear();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            if (listView1.SelectedItems.Count > 0)
            {
                sqlCmd.CommandText = "Select * from DONDH where MaNCC = '" + listView1.SelectedItems[0].Text + "'";
                sqlCmd.Connection = conn;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem lv = new ListViewItem(reader["SoDH"].ToString());
                    lv.SubItems.Add(reader["NgayDH"].ToString());
                    lv.SubItems.Add(reader["MaNCC"].ToString());
                    listView2.Items.Add(lv);
                }
                conn.Close();
            }

        }
    }
}
