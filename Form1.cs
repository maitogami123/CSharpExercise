using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaagaaAppu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            addRecordToTable((sender as Button).Text.ToString());
        }

        private void addRecordToTable(string record)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowFound = dataGridView1.Rows[i].Cells[0].Value;
                if ($"{rowFound}".Equals(record))
                {
                    dataGridView1.Rows[i].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) + 1;
                    return;
                }
            }
            DataGridViewRow newRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            newRow.Cells[0].Value = record;
            newRow.Cells[1].Value = 1;
            dataGridView1.Rows.Add(newRow);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            } catch
            {
                MessageBox.Show("Không được xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView1.Rows.Count < 2)
            {
                MessageBox.Show("Vui lòng chọn món!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Đặt món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Rows.Clear();
            comboBox1.SelectedItem = null;
            comboBox1.Text = "--- Chọn bàn ---";
        }
    }
}
