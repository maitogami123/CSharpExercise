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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataReader
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

            KetnoiCSDL();
            LoadListview();
        }

        SqlConnection sqlConn;  //khai báo biến connection
        SqlDataAdapter da;		//khai báo biến dataAdapter
        DataSet ds = new DataSet();	//khai báo 1 dataset
        public string srvName = "SAPLING\\SAPLING";	//chỉ định tên server
        public string dbName = "QLTHUVIEN";   //chỉ định tên CSDL
        public string selectedName = "";
        void KetnoiCSDL() //thực hiện kết nối bằng chuỗi kết nối
        {
            string connStr = "Data source=" + srvName + ";database=" + dbName + ";Integrated Security = True";
            sqlConn = new SqlConnection(connStr);
        }

        DataTable layDanhSachNhanVien()
        {
            string sql = "Select * from NhanVien"; da = new SqlDataAdapter(sql, sqlConn); da.Fill(ds);
            return ds.Tables[0];
        }

        void LoadListview()
        {

            listView1.FullRowSelect = true; //cho phép chọn 1 dòng
            listView1.View = View.Details; //cho phép hiển thị thông tin chi tiết dạng bảng
            DataTable dt = layDanhSachNhanVien();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = listView1.Items.Add(dt.Rows[i]["Hotennhanvien"].ToString());
                //dòng thứ i, tên cột là nhân viên
                lvi.SubItems.Add(dt.Rows[i][2].ToString()); //dùng chỉ số cột : dòng thứ i,cột thứ 1
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
            }
        }

        void LoadNewItemInList()
        {
            DataTable dt = layDanhSachNhanVien();
            ListViewItem lvi = listView1.Items.Add(textBox1.Text);
            //dòng thứ i, tên cột là nhân viên
            lvi.SubItems.Add(dateTimePicker1.Value.ToShortDateString()); //dùng chỉ số cột : dòng thứ i,cột thứ 1
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into NHANVIEN values('{0}','{1}','{2}','{3}','{4}')", 
                textBox1.Text, 
                dateTimePicker1.Value.ToShortDateString(),
                textBox2.Text, 
                textBox3.Text, 
                1); 
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            sqlConn.Open();
            cmd.ExecuteNonQuery();
            LoadNewItemInList();
            sqlConn.Close();
            MessageBox.Show("Thêm thành công!");
        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                textBox1.Text = item.SubItems[0].Text;
                dateTimePicker1.Value = DateTime.Parse(item.SubItems[1].Text);
                textBox2.Text = item.SubItems[2].Text;
                textBox3.Text = item.SubItems[3].Text;
                selectedName = item.SubItems[0].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string sql = string.Format("delete from NHANVIEN where HoTenNhanVien = '{0}'", item.SubItems[0].Text);
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                listView1.SelectedItems[0].Remove();
                sqlConn.Close();
                MessageBox.Show("Xóa thành công");
            }   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string sql = string.Format("update NHANVIEN set HoTenNhanVien='{0}', NgaySinh='{1}', DiaChi='{2}', DienThoai='{3}' where HoTenNhanVien='{4}'",
                    textBox1.Text,
                    dateTimePicker1.Value.ToShortDateString(),
                    textBox2.Text,
                    textBox3.Text,
                    selectedName
                    );
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sqlConn.Close();
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Value.ToShortDateString();
                listView1.SelectedItems[0].SubItems[2].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox3.Text;
                MessageBox.Show("Sửa thành công!");

            }
        }
    }
}

