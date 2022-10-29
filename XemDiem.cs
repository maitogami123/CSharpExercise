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
    public partial class XemDiem : Form
    {
        public XemDiem()
        {
            InitializeComponent();
        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanlysinhvienDataSet.SinhVien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = global::StudentManagement.Properties.Settings.Default.QuanlysinhvienConnectionString; 
            string str;
            // truy vấn lấy điểm các môn học của SV có mã số được chọn
            str = string.Format("Select TenMH, Diem From KetQua,Mon where [KetQua].MaMH = [Mon].MaMH AND MaSo = {0}", comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(str, conn); DataSet ds = new DataSet();
            // đổ vào dataset
            da.Fill(ds);
            // hiển thị ra
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
