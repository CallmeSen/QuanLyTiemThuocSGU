namespace QuanLyThuVienSGU_Winform
{
    partial class fc_EditMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fc_EditMed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer_ChinhSuaTaiKhoanTransition = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.label_NgayNhap = new System.Windows.Forms.Label();
            this.label_NhaCungCap = new System.Windows.Forms.Label();
            this.label_TenThuoc = new System.Windows.Forms.Label();
            this.button_ResetUpdate = new System.Windows.Forms.Button();
            this.label_IDUpdateInput = new System.Windows.Forms.Label();
            this.button_SaveUpdate = new System.Windows.Forms.Button();
            this.label_ChinhSuaThongTinNhanVien = new System.Windows.Forms.Label();
            this.panel_SearchFunction = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.dataGridView_ChinhSuaThuoc = new System.Windows.Forms.DataGridView();
            this.panel_Null3 = new System.Windows.Forms.Panel();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_ThongTinThuoc = new System.Windows.Forms.Label();
            this.panel_ChinhSuaThuoc = new System.Windows.Forms.Panel();
            this.txbGiaThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbGiaThuoc = new System.Windows.Forms.Label();
            this.DTP_NgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DTP_NgayHetHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txbSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDCapNhat = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_NgayHetHan = new System.Windows.Forms.Label();
            this.panel_Null1 = new System.Windows.Forms.Panel();
            this.panel_Null2 = new System.Windows.Forms.Panel();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycuahangthuocDataSet = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSet();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.employeesTableAdapter = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSetTableAdapters.EmployeesTableAdapter();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNhomThuoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.panel_SearchFunction.SuspendLayout();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChinhSuaThuoc)).BeginInit();
            this.panel_Null3.SuspendLayout();
            this.panel_ChinhSuaThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_ChinhSuaTaiKhoanTransition
            // 
            this.timer_ChinhSuaTaiKhoanTransition.Interval = 10;
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(3346, 0);
            this.pictureBox_Exit.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(109, 98);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exit.TabIndex = 31;
            this.pictureBox_Exit.TabStop = false;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSoLuong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSoLuong.Location = new System.Drawing.Point(1934, 76);
            this.lbSoLuong.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(239, 65);
            this.lbSoLuong.TabIndex = 20;
            this.lbSoLuong.Text = "Số lượng*";
            // 
            // label_NgayNhap
            // 
            this.label_NgayNhap.AutoSize = true;
            this.label_NgayNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_NgayNhap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NgayNhap.Location = new System.Drawing.Point(736, 265);
            this.label_NgayNhap.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_NgayNhap.Name = "label_NgayNhap";
            this.label_NgayNhap.Size = new System.Drawing.Size(291, 65);
            this.label_NgayNhap.TabIndex = 32;
            this.label_NgayNhap.Text = "Ngày nhập *";
            // 
            // label_NhaCungCap
            // 
            this.label_NhaCungCap.AutoSize = true;
            this.label_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NhaCungCap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NhaCungCap.Location = new System.Drawing.Point(1229, 76);
            this.label_NhaCungCap.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_NhaCungCap.Name = "label_NhaCungCap";
            this.label_NhaCungCap.Size = new System.Drawing.Size(368, 65);
            this.label_NhaCungCap.TabIndex = 27;
            this.label_NhaCungCap.Text = "Nhà Cung Cấp *";
            // 
            // label_TenThuoc
            // 
            this.label_TenThuoc.AutoSize = true;
            this.label_TenThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TenThuoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_TenThuoc.Location = new System.Drawing.Point(435, 76);
            this.label_TenThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_TenThuoc.Name = "label_TenThuoc";
            this.label_TenThuoc.Size = new System.Drawing.Size(275, 65);
            this.label_TenThuoc.TabIndex = 25;
            this.label_TenThuoc.Text = "Tên Thuốc *";
            // 
            // button_ResetUpdate
            // 
            this.button_ResetUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_ResetUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ResetUpdate.FlatAppearance.BorderSize = 0;
            this.button_ResetUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetUpdate.ForeColor = System.Drawing.Color.White;
            this.button_ResetUpdate.Location = new System.Drawing.Point(3042, 322);
            this.button_ResetUpdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ResetUpdate.Name = "button_ResetUpdate";
            this.button_ResetUpdate.Size = new System.Drawing.Size(344, 114);
            this.button_ResetUpdate.TabIndex = 24;
            this.button_ResetUpdate.Text = "Reset";
            this.button_ResetUpdate.UseVisualStyleBackColor = false;
            // 
            // label_IDUpdateInput
            // 
            this.label_IDUpdateInput.AutoSize = true;
            this.label_IDUpdateInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_IDUpdateInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDUpdateInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_IDUpdateInput.Location = new System.Drawing.Point(32, 76);
            this.label_IDUpdateInput.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_IDUpdateInput.Name = "label_IDUpdateInput";
            this.label_IDUpdateInput.Size = new System.Drawing.Size(108, 65);
            this.label_IDUpdateInput.TabIndex = 20;
            this.label_IDUpdateInput.Text = "ID *";
            // 
            // button_SaveUpdate
            // 
            this.button_SaveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_SaveUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveUpdate.FlatAppearance.BorderSize = 0;
            this.button_SaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveUpdate.ForeColor = System.Drawing.Color.White;
            this.button_SaveUpdate.Location = new System.Drawing.Point(2615, 322);
            this.button_SaveUpdate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_SaveUpdate.Name = "button_SaveUpdate";
            this.button_SaveUpdate.Size = new System.Drawing.Size(368, 114);
            this.button_SaveUpdate.TabIndex = 23;
            this.button_SaveUpdate.Text = "Save";
            this.button_SaveUpdate.UseVisualStyleBackColor = false;
            // 
            // label_ChinhSuaThongTinNhanVien
            // 
            this.label_ChinhSuaThongTinNhanVien.AutoSize = true;
            this.label_ChinhSuaThongTinNhanVien.BackColor = System.Drawing.Color.White;
            this.label_ChinhSuaThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChinhSuaThongTinNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.label_ChinhSuaThongTinNhanVien.Location = new System.Drawing.Point(27, 5);
            this.label_ChinhSuaThongTinNhanVien.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ChinhSuaThongTinNhanVien.Name = "label_ChinhSuaThongTinNhanVien";
            this.label_ChinhSuaThongTinNhanVien.Size = new System.Drawing.Size(635, 65);
            this.label_ChinhSuaThongTinNhanVien.TabIndex = 15;
            this.label_ChinhSuaThongTinNhanVien.Text = "Chỉnh sửa Thông tin Thuốc\r\n";
            this.label_ChinhSuaThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_SearchFunction
            // 
            this.panel_SearchFunction.BackColor = System.Drawing.Color.White;
            this.panel_SearchFunction.Controls.Add(this.panel_Main);
            this.panel_SearchFunction.Controls.Add(this.panel_Null1);
            this.panel_SearchFunction.Controls.Add(this.panel_Null2);
            this.panel_SearchFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SearchFunction.Location = new System.Drawing.Point(0, 0);
            this.panel_SearchFunction.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_SearchFunction.Name = "panel_SearchFunction";
            this.panel_SearchFunction.Size = new System.Drawing.Size(3597, 1638);
            this.panel_SearchFunction.TabIndex = 3;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.dataGridView_ChinhSuaThuoc);
            this.panel_Main.Controls.Add(this.panel_Null3);
            this.panel_Main.Controls.Add(this.panel_ChinhSuaThuoc);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(83, 0);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(3455, 1638);
            this.panel_Main.TabIndex = 20;
            // 
            // dataGridView_ChinhSuaThuoc
            // 
            this.dataGridView_ChinhSuaThuoc.AllowUserToAddRows = false;
            this.dataGridView_ChinhSuaThuoc.AllowUserToDeleteRows = false;
            this.dataGridView_ChinhSuaThuoc.AllowUserToResizeColumns = false;
            this.dataGridView_ChinhSuaThuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaThuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ChinhSuaThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaThuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ChinhSuaThuoc.ColumnHeadersHeight = 40;
            this.dataGridView_ChinhSuaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ChinhSuaThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ChinhSuaThuoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ChinhSuaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChinhSuaThuoc.EnableHeadersVisualStyles = false;
            this.dataGridView_ChinhSuaThuoc.GridColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaThuoc.Location = new System.Drawing.Point(0, 212);
            this.dataGridView_ChinhSuaThuoc.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView_ChinhSuaThuoc.Name = "dataGridView_ChinhSuaThuoc";
            this.dataGridView_ChinhSuaThuoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaThuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_ChinhSuaThuoc.RowHeadersVisible = false;
            this.dataGridView_ChinhSuaThuoc.RowHeadersWidth = 100;
            this.dataGridView_ChinhSuaThuoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.dataGridView_ChinhSuaThuoc.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ChinhSuaThuoc.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_ChinhSuaThuoc.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaThuoc.RowTemplate.Height = 24;
            this.dataGridView_ChinhSuaThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ChinhSuaThuoc.Size = new System.Drawing.Size(3455, 946);
            this.dataGridView_ChinhSuaThuoc.TabIndex = 0;
            // 
            // panel_Null3
            // 
            this.panel_Null3.Controls.Add(this.txbSearch);
            this.panel_Null3.Controls.Add(this.button_Search);
            this.panel_Null3.Controls.Add(this.label_ThongTinThuoc);
            this.panel_Null3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Null3.Location = new System.Drawing.Point(0, 0);
            this.panel_Null3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Null3.Name = "panel_Null3";
            this.panel_Null3.Size = new System.Drawing.Size(3455, 212);
            this.panel_Null3.TabIndex = 0;
            // 
            // txbSearch
            // 
            this.txbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSearch.DefaultText = "";
            this.txbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSearch.Location = new System.Drawing.Point(0, 95);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "Nhập tên thuốc";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(1280, 95);
            this.txbSearch.TabIndex = 10;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(3042, 95);
            this.button_Search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(413, 93);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // label_ThongTinThuoc
            // 
            this.label_ThongTinThuoc.AutoSize = true;
            this.label_ThongTinThuoc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinThuoc.Location = new System.Drawing.Point(-13, 7);
            this.label_ThongTinThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_ThongTinThuoc.Name = "label_ThongTinThuoc";
            this.label_ThongTinThuoc.Size = new System.Drawing.Size(499, 71);
            this.label_ThongTinThuoc.TabIndex = 6;
            this.label_ThongTinThuoc.Text = "THÔNG TIN THUỐC";
            this.label_ThongTinThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_ChinhSuaThuoc
            // 
            this.panel_ChinhSuaThuoc.Controls.Add(this.guna2TextBox1);
            this.panel_ChinhSuaThuoc.Controls.Add(this.lbNhomThuoc);
            this.panel_ChinhSuaThuoc.Controls.Add(this.txbGiaThuoc);
            this.panel_ChinhSuaThuoc.Controls.Add(this.lbGiaThuoc);
            this.panel_ChinhSuaThuoc.Controls.Add(this.DTP_NgayNhap);
            this.panel_ChinhSuaThuoc.Controls.Add(this.DTP_NgayHetHan);
            this.panel_ChinhSuaThuoc.Controls.Add(this.txbSoLuong);
            this.panel_ChinhSuaThuoc.Controls.Add(this.txbTenThuoc);
            this.panel_ChinhSuaThuoc.Controls.Add(this.txbIDCapNhat);
            this.panel_ChinhSuaThuoc.Controls.Add(this.cbNhaCungCap);
            this.panel_ChinhSuaThuoc.Controls.Add(this.label_NgayHetHan);
            this.panel_ChinhSuaThuoc.Controls.Add(this.label_NgayNhap);
            this.panel_ChinhSuaThuoc.Controls.Add(this.pictureBox_Exit);
            this.panel_ChinhSuaThuoc.Controls.Add(this.lbSoLuong);
            this.panel_ChinhSuaThuoc.Controls.Add(this.label_NhaCungCap);
            this.panel_ChinhSuaThuoc.Controls.Add(this.label_TenThuoc);
            this.panel_ChinhSuaThuoc.Controls.Add(this.button_ResetUpdate);
            this.panel_ChinhSuaThuoc.Controls.Add(this.label_IDUpdateInput);
            this.panel_ChinhSuaThuoc.Controls.Add(this.button_SaveUpdate);
            this.panel_ChinhSuaThuoc.Controls.Add(this.label_ChinhSuaThongTinNhanVien);
            this.panel_ChinhSuaThuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ChinhSuaThuoc.Location = new System.Drawing.Point(0, 1158);
            this.panel_ChinhSuaThuoc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_ChinhSuaThuoc.Name = "panel_ChinhSuaThuoc";
            this.panel_ChinhSuaThuoc.Size = new System.Drawing.Size(3455, 480);
            this.panel_ChinhSuaThuoc.TabIndex = 28;
            // 
            // txbGiaThuoc
            // 
            this.txbGiaThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbGiaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGiaThuoc.DefaultText = "";
            this.txbGiaThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbGiaThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbGiaThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbGiaThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbGiaThuoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbGiaThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbGiaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbGiaThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbGiaThuoc.Location = new System.Drawing.Point(2723, 138);
            this.txbGiaThuoc.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txbGiaThuoc.Name = "txbGiaThuoc";
            this.txbGiaThuoc.PasswordChar = '\0';
            this.txbGiaThuoc.PlaceholderText = "";
            this.txbGiaThuoc.SelectedText = "";
            this.txbGiaThuoc.Size = new System.Drawing.Size(619, 110);
            this.txbGiaThuoc.TabIndex = 43;
            // 
            // lbGiaThuoc
            // 
            this.lbGiaThuoc.AutoSize = true;
            this.lbGiaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbGiaThuoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbGiaThuoc.Location = new System.Drawing.Point(2710, 76);
            this.lbGiaThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbGiaThuoc.Name = "lbGiaThuoc";
            this.lbGiaThuoc.Size = new System.Drawing.Size(259, 65);
            this.lbGiaThuoc.TabIndex = 42;
            this.lbGiaThuoc.Text = "Giá Thuốc*";
            // 
            // DTP_NgayNhap
            // 
            this.DTP_NgayNhap.Checked = true;
            this.DTP_NgayNhap.FillColor = System.Drawing.Color.White;
            this.DTP_NgayNhap.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_NgayNhap.Location = new System.Drawing.Point(747, 344);
            this.DTP_NgayNhap.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DTP_NgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_NgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_NgayNhap.Name = "DTP_NgayNhap";
            this.DTP_NgayNhap.Size = new System.Drawing.Size(616, 107);
            this.DTP_NgayNhap.TabIndex = 41;
            this.DTP_NgayNhap.Value = new System.DateTime(2024, 11, 12, 7, 57, 42, 17);
            // 
            // DTP_NgayHetHan
            // 
            this.DTP_NgayHetHan.Checked = true;
            this.DTP_NgayHetHan.FillColor = System.Drawing.Color.White;
            this.DTP_NgayHetHan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_NgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_NgayHetHan.Location = new System.Drawing.Point(1502, 347);
            this.DTP_NgayHetHan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DTP_NgayHetHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_NgayHetHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_NgayHetHan.Name = "DTP_NgayHetHan";
            this.DTP_NgayHetHan.Size = new System.Drawing.Size(616, 107);
            this.DTP_NgayHetHan.TabIndex = 40;
            this.DTP_NgayHetHan.Value = new System.DateTime(2024, 11, 12, 7, 57, 42, 17);
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoLuong.DefaultText = "";
            this.txbSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoLuong.Location = new System.Drawing.Point(1947, 138);
            this.txbSoLuong.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.PasswordChar = '\0';
            this.txbSoLuong.PlaceholderText = "";
            this.txbSoLuong.SelectedText = "";
            this.txbSoLuong.Size = new System.Drawing.Size(619, 110);
            this.txbSoLuong.TabIndex = 39;
            // 
            // txbTenThuoc
            // 
            this.txbTenThuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbTenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenThuoc.DefaultText = "";
            this.txbTenThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTenThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTenThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTenThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTenThuoc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbTenThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTenThuoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbTenThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTenThuoc.Location = new System.Drawing.Point(448, 138);
            this.txbTenThuoc.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbTenThuoc.Name = "txbTenThuoc";
            this.txbTenThuoc.PasswordChar = '\0';
            this.txbTenThuoc.PlaceholderText = "";
            this.txbTenThuoc.SelectedText = "";
            this.txbTenThuoc.Size = new System.Drawing.Size(661, 110);
            this.txbTenThuoc.TabIndex = 38;
            // 
            // txbIDCapNhat
            // 
            this.txbIDCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbIDCapNhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCapNhat.DefaultText = "";
            this.txbIDCapNhat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbIDCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbIDCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbIDCapNhat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbIDCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbIDCapNhat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbIDCapNhat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCapNhat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbIDCapNhat.Location = new System.Drawing.Point(40, 138);
            this.txbIDCapNhat.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbIDCapNhat.Name = "txbIDCapNhat";
            this.txbIDCapNhat.PasswordChar = '\0';
            this.txbIDCapNhat.PlaceholderText = "";
            this.txbIDCapNhat.SelectedText = "";
            this.txbIDCapNhat.Size = new System.Drawing.Size(264, 110);
            this.txbIDCapNhat.TabIndex = 37;
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cbNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCungCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cbNhaCungCap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNhaCungCap.ItemHeight = 30;
            this.cbNhaCungCap.Location = new System.Drawing.Point(1243, 162);
            this.cbNhaCungCap.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(516, 36);
            this.cbNhaCungCap.TabIndex = 36;
            // 
            // label_NgayHetHan
            // 
            this.label_NgayHetHan.AutoSize = true;
            this.label_NgayHetHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_NgayHetHan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayHetHan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NgayHetHan.Location = new System.Drawing.Point(1491, 262);
            this.label_NgayHetHan.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_NgayHetHan.Name = "label_NgayHetHan";
            this.label_NgayHetHan.Size = new System.Drawing.Size(344, 65);
            this.label_NgayHetHan.TabIndex = 34;
            this.label_NgayHetHan.Text = "Ngày hết hạn *";
            // 
            // panel_Null1
            // 
            this.panel_Null1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Null1.Location = new System.Drawing.Point(0, 0);
            this.panel_Null1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Null1.Name = "panel_Null1";
            this.panel_Null1.Size = new System.Drawing.Size(83, 1638);
            this.panel_Null1.TabIndex = 18;
            // 
            // panel_Null2
            // 
            this.panel_Null2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Null2.Location = new System.Drawing.Point(3538, 0);
            this.panel_Null2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Null2.Name = "panel_Null2";
            this.panel_Null2.Size = new System.Drawing.Size(59, 1638);
            this.panel_Null2.TabIndex = 19;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.quanlycuahangthuocDataSet;
            // 
            // quanlycuahangthuocDataSet
            // 
            this.quanlycuahangthuocDataSet.DataSetName = "quanlycuahangthuocDataSet";
            this.quanlycuahangthuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(38, 344);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(19);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(619, 110);
            this.guna2TextBox1.TabIndex = 45;
            // 
            // lbNhomThuoc
            // 
            this.lbNhomThuoc.AutoSize = true;
            this.lbNhomThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNhomThuoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhomThuoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNhomThuoc.Location = new System.Drawing.Point(30, 260);
            this.lbNhomThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNhomThuoc.Name = "lbNhomThuoc";
            this.lbNhomThuoc.Size = new System.Drawing.Size(322, 65);
            this.lbNhomThuoc.TabIndex = 44;
            this.lbNhomThuoc.Text = "Nhóm Thuốc*";
            // 
            // fc_EditMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3597, 1638);
            this.Controls.Add(this.panel_SearchFunction);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "fc_EditMed";
            this.Text = "fcThemXoaThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.panel_SearchFunction.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChinhSuaThuoc)).EndInit();
            this.panel_Null3.ResumeLayout(false);
            this.panel_Null3.PerformLayout();
            this.panel_ChinhSuaThuoc.ResumeLayout(false);
            this.panel_ChinhSuaThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_ChinhSuaTaiKhoanTransition;
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label label_NgayNhap;
        private System.Windows.Forms.Label label_NhaCungCap;
        private System.Windows.Forms.Label label_TenThuoc;
        private System.Windows.Forms.Button button_ResetUpdate;
        private System.Windows.Forms.Label label_IDUpdateInput;
        private System.Windows.Forms.Button button_SaveUpdate;
        private System.Windows.Forms.Label label_ChinhSuaThongTinNhanVien;
        private System.Windows.Forms.Panel panel_SearchFunction;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView_ChinhSuaThuoc;
        private System.Windows.Forms.Panel panel_Null3;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ThongTinThuoc;
        private System.Windows.Forms.Panel panel_ChinhSuaThuoc;
        private System.Windows.Forms.Label label_NgayHetHan;
        private System.Windows.Forms.Panel panel_Null1;
        private System.Windows.Forms.Panel panel_Null2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private quanlycuahangthuocDataSet quanlycuahangthuocDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private quanlycuahangthuocDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txbIDCapNhat;
        private Guna.UI2.WinForms.Guna2ComboBox cbNhaCungCap;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_NgayNhap;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_NgayHetHan;
        private Guna.UI2.WinForms.Guna2TextBox txbSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txbTenThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbGiaThuoc;
        private System.Windows.Forms.Label lbGiaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label lbNhomThuoc;
    }
}