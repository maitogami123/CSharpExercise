namespace StudentManagement
{
    partial class NhapDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label diemLabel;
            System.Windows.Forms.Label maSoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapDiem));
            this.quanlysinhvienDataSet = new StudentManagement.QuanlysinhvienDataSet();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new StudentManagement.QuanlysinhvienDataSetTableAdapters.KetQuaTableAdapter();
            this.tableAdapterManager = new StudentManagement.QuanlysinhvienDataSetTableAdapters.TableAdapterManager();
            this.monTableAdapter = new StudentManagement.QuanlysinhvienDataSetTableAdapters.MonTableAdapter();
            this.sinhVienTableAdapter = new StudentManagement.QuanlysinhvienDataSetTableAdapters.SinhVienTableAdapter();
            this.ketQuaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ketQuaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ketQuaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tenMHComboBox = new System.Windows.Forms.ComboBox();
            this.diemTextBox = new System.Windows.Forms.TextBox();
            this.maSoComboBox = new System.Windows.Forms.ComboBox();
            this.maMHComboBox = new System.Windows.Forms.ComboBox();
            this.hoTenComboBox = new System.Windows.Forms.ComboBox();
            tenMHLabel = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            diemLabel = new System.Windows.Forms.Label();
            maSoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).BeginInit();
            this.ketQuaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tenMHLabel
            // 
            tenMHLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(107, 184);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(58, 16);
            tenMHLabel.TabIndex = 10;
            tenMHLabel.Text = "Tên MH:";
            // 
            // maMHLabel
            // 
            maMHLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(112, 129);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(53, 16);
            maMHLabel.TabIndex = 4;
            maMHLabel.Text = "Mã MH:";
            // 
            // hoTenLabel
            // 
            hoTenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(110, 74);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(55, 16);
            hoTenLabel.TabIndex = 8;
            hoTenLabel.Text = "Họ Tên:";
            // 
            // diemLabel
            // 
            diemLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            diemLabel.AutoSize = true;
            diemLabel.Location = new System.Drawing.Point(127, 240);
            diemLabel.Name = "diemLabel";
            diemLabel.Size = new System.Drawing.Size(38, 16);
            diemLabel.TabIndex = 11;
            diemLabel.Text = "Điểm";
            // 
            // maSoLabel
            // 
            maSoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(118, 19);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(47, 16);
            maSoLabel.TabIndex = 2;
            maSoLabel.Text = "Mã số:";
            // 
            // quanlysinhvienDataSet
            // 
            this.quanlysinhvienDataSet.DataSetName = "QuanlysinhvienDataSet";
            this.quanlysinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.quanlysinhvienDataSet;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = this.monTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentManagement.QuanlysinhvienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // ketQuaBindingNavigator
            // 
            this.ketQuaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ketQuaBindingNavigator.BindingSource = this.ketQuaBindingSource;
            this.ketQuaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ketQuaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ketQuaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ketQuaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ketQuaBindingNavigatorSaveItem});
            this.ketQuaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ketQuaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ketQuaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ketQuaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ketQuaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ketQuaBindingNavigator.Name = "ketQuaBindingNavigator";
            this.ketQuaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ketQuaBindingNavigator.Size = new System.Drawing.Size(560, 31);
            this.ketQuaBindingNavigator.TabIndex = 0;
            this.ketQuaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // ketQuaBindingNavigatorSaveItem
            // 
            this.ketQuaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ketQuaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ketQuaBindingNavigatorSaveItem.Image")));
            this.ketQuaBindingNavigatorSaveItem.Name = "ketQuaBindingNavigatorSaveItem";
            this.ketQuaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.ketQuaBindingNavigatorSaveItem.Text = "Save Data";
            this.ketQuaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ketQuaBindingNavigatorSaveItem_Click_1);
            // 
            // ketQuaDataGridView
            // 
            this.ketQuaDataGridView.AutoGenerateColumns = false;
            this.ketQuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ketQuaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ketQuaDataGridView.DataSource = this.ketQuaBindingSource;
            this.ketQuaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ketQuaDataGridView.Location = new System.Drawing.Point(0, 308);
            this.ketQuaDataGridView.Name = "ketQuaDataGridView";
            this.ketQuaDataGridView.RowHeadersWidth = 51;
            this.ketQuaDataGridView.RowTemplate.Height = 24;
            this.ketQuaDataGridView.Size = new System.Drawing.Size(560, 220);
            this.ketQuaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSo";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Diem";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.quanlysinhvienDataSet;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.quanlysinhvienDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 277);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(maSoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tenMHComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(tenMHLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.diemTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(diemLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.maSoComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(maMHLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maMHComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(hoTenLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoTenComboBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 277);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tenMHComboBox
            // 
            this.tenMHComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tenMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monBindingSource, "TenMH", true));
            this.tenMHComboBox.DataSource = this.monBindingSource;
            this.tenMHComboBox.DisplayMember = "TenMH";
            this.tenMHComboBox.Enabled = false;
            this.tenMHComboBox.FormattingEnabled = true;
            this.tenMHComboBox.Location = new System.Drawing.Point(171, 180);
            this.tenMHComboBox.Name = "tenMHComboBox";
            this.tenMHComboBox.Size = new System.Drawing.Size(276, 24);
            this.tenMHComboBox.TabIndex = 11;
            // 
            // diemTextBox
            // 
            this.diemTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.diemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "Diem", true));
            this.diemTextBox.Location = new System.Drawing.Point(171, 237);
            this.diemTextBox.Name = "diemTextBox";
            this.diemTextBox.Size = new System.Drawing.Size(276, 22);
            this.diemTextBox.TabIndex = 12;
            // 
            // maSoComboBox
            // 
            this.maSoComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maSoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaSo", true));
            this.maSoComboBox.DataSource = this.sinhVienBindingSource;
            this.maSoComboBox.DisplayMember = "MaSo";
            this.maSoComboBox.FormattingEnabled = true;
            this.maSoComboBox.Location = new System.Drawing.Point(171, 15);
            this.maSoComboBox.Name = "maSoComboBox";
            this.maSoComboBox.Size = new System.Drawing.Size(276, 24);
            this.maSoComboBox.TabIndex = 3;
            // 
            // maMHComboBox
            // 
            this.maMHComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaMH", true));
            this.maMHComboBox.DataSource = this.monBindingSource;
            this.maMHComboBox.DisplayMember = "MaMH";
            this.maMHComboBox.FormattingEnabled = true;
            this.maMHComboBox.Location = new System.Drawing.Point(171, 125);
            this.maMHComboBox.Name = "maMHComboBox";
            this.maMHComboBox.Size = new System.Drawing.Size(276, 24);
            this.maMHComboBox.TabIndex = 5;
            // 
            // hoTenComboBox
            // 
            this.hoTenComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hoTenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sinhVienBindingSource, "HoTen", true));
            this.hoTenComboBox.DataSource = this.sinhVienBindingSource;
            this.hoTenComboBox.DisplayMember = "HoTen";
            this.hoTenComboBox.Enabled = false;
            this.hoTenComboBox.FormattingEnabled = true;
            this.hoTenComboBox.Location = new System.Drawing.Point(171, 70);
            this.hoTenComboBox.Name = "hoTenComboBox";
            this.hoTenComboBox.Size = new System.Drawing.Size(276, 24);
            this.hoTenComboBox.TabIndex = 9;
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ketQuaDataGridView);
            this.Controls.Add(this.ketQuaBindingNavigator);
            this.Name = "NhapDiem";
            this.Text = "NhapDiem";
            this.Load += new System.EventHandler(this.KetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlysinhvienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).EndInit();
            this.ketQuaBindingNavigator.ResumeLayout(false);
            this.ketQuaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanlysinhvienDataSet quanlysinhvienDataSet;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private QuanlysinhvienDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private QuanlysinhvienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ketQuaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ketQuaBindingNavigatorSaveItem;
        private QuanlysinhvienDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridView ketQuaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QuanlysinhvienDataSetTableAdapters.MonTableAdapter monTableAdapter;
        private System.Windows.Forms.BindingSource monBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox hoTenComboBox;
        private System.Windows.Forms.TextBox diemTextBox;
        private System.Windows.Forms.ComboBox maMHComboBox;
        private System.Windows.Forms.ComboBox tenMHComboBox;
        private System.Windows.Forms.ComboBox maSoComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}