using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void khoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanlysinhvienDataSet);

        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlysinhvienDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanlysinhvienDataSet.Khoa);

        }
    }
}
