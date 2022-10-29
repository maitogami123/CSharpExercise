using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagement
{
    public partial class NhapDiem : Form
    {
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void ketQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlysinhvienDataSet);

        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.quanlysinhvienDataSet.Mon);
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanlysinhvienDataSet.SinhVien);
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.quanlysinhvienDataSet.KetQua);
            //// TODO: This line of code loads data into the 'quanlysinhvienDataSet.Mon' table. You can move, or remove it, as needed.
            //this.monTableAdapter.Fill(this.quanlysinhvienDataSet.Mon);
            //// TODO: This line of code loads data into the 'quanlysinhvienDataSet.SinhVien' table. You can move, or remove it, as needed.
            //this.sinhVienTableAdapter.Fill(this.quanlysinhvienDataSet.SinhVien);
            //// TODO: This line of code loads data into the 'quanlysinhvienDataSet.KetQua' table. You can move, or remove it, as needed.
            //this.ketQuaTableAdapter.Fill(this.quanlysinhvienDataSet.KetQua);

        }

        private void ketQuaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlysinhvienDataSet);

        }
    }
}
