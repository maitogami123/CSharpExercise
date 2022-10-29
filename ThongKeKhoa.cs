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

namespace StudentManagement
{
    public partial class ThongKeKhoa : Form
    {
        public ThongKeKhoa()
        {
            InitializeComponent();
        }

        private void ThongKeKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanlysinhvienDataSet.Khoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = global::StudentManagement.Properties.Settings.Default.QuanlysinhvienConnectionString;
            string str;

            str = string.Format("Select MaSo,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai From SinhVien where idMaKhoa = '{0}'", comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn); 
            DataSet ds = new DataSet();
            // đổ vào dataset
            da.Fill(ds);
            // hiển thị ra
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
