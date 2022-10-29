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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            addForm(new Init());
        }
        private void addForm(Form form)
        {
            int displayPosition = 0;
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                displayPosition += 10;
                if (f.Text == form.Text)
                {
                    isOpen = true;
                    f.BringToFront();
                    f.Activate();
                }
            }

            if (isOpen == false)
            {
                form.TopLevel = false;
                form.AutoScroll = true;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                panel1.Controls.Add(form);
                form.Show();
                form.SetDesktopLocation(displayPosition, displayPosition);
                form.BringToFront();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addForm(new SinhVien());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addForm(new Khoa());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            addForm(new Mon());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addForm(new NhapDiem());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            addForm(new XemDiem());
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            addForm(new ThongKeKhoa());
        }
    }
}
