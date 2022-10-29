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

namespace StudentManagement
{
    public partial class Experimental : Form
    {
        // This form is for testing purpose!
        public Experimental()
        {
            InitializeComponent();
        }

        private void ketQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string conn = global::StudentManagement.Properties.Settings.Default.QuanlysinhvienConnectionString;
            string str;
            // truy vấn lấy điểm các môn học của SV có mã số được chọn
            str = "insert into KetQua (KetQua.[MaSo], KetQua.[MaMH], KetQua.[Diem]) values(@maso, @mamh, @diem)";
            //SqlDataAdapter da = new SqlDataAdapter(str, conn);
            using(SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(str, con)) {
                        // Create and set the parameters values 
                        cmd.Parameters.Add("@maso", SqlDbType.NChar).Value = comboBox1.Text;
                        cmd.Parameters.Add("@mamh", SqlDbType.NChar).Value = comboBox3.Text;
                        cmd.Parameters.Add("@diem", SqlDbType.Int).Value = textBox1.Text;

                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            MessageBox.Show("Row inserted!!");
                            this.ketQuaTableAdapter.Fill(this.quanlysinhvienDataSet.KetQua);
                        }
                        else
                            // Well this should never really happen
                            MessageBox.Show("No row inserted");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex.Message);
                }
            }
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
        }

        private void Experimental_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.quanlysinhvienDataSet.Mon);
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanlysinhvienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.quanlysinhvienDataSet.KetQua);

        }
    }
}
