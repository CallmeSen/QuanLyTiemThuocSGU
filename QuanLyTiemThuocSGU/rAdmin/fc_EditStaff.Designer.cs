namespace QuanLyThuVienSGU_Winform
{
    partial class fc_EditStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fc_EditStaff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox_Exit = new System.Windows.Forms.PictureBox();
            this.label_SoDienThoaiUpdateInput = new System.Windows.Forms.Label();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.label_ChucVu = new System.Windows.Forms.Label();
            this.label_HoVaTenUpdateInput = new System.Windows.Forms.Label();
            this.label_IDUpdateInput = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label_ChinhSuaThongTinNhanVien = new System.Windows.Forms.Label();
            this.panel_SearchFunction = new System.Windows.Forms.Panel();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.dataGridView_ChinhSuaTaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel_Null3 = new System.Windows.Forms.Panel();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_ThongTinNhanVien = new System.Windows.Forms.Label();
            this.panel_ChinhSuaTaiKhoan = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbLuong = new System.Windows.Forms.Label();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.DTP_NgayNhanViec = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txbSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDCapNhat = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbChucVu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label_NgayNhanViec = new System.Windows.Forms.Label();
            this.panel_Null1 = new System.Windows.Forms.Panel();
            this.panel_Null2 = new System.Windows.Forms.Panel();
            this.quanlycuahangthuocDataSet = new QuanLyThuVienSGU_Winform.quanlycuahangthuocDataSet();
            this.txbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).BeginInit();
            this.panel_SearchFunction.SuspendLayout();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChinhSuaTaiKhoan)).BeginInit();
            this.panel_Null3.SuspendLayout();
            this.panel_ChinhSuaTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Exit
            // 
            this.pictureBox_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Exit.Image")));
            this.pictureBox_Exit.Location = new System.Drawing.Point(1318, 0);
            this.pictureBox_Exit.Name = "pictureBox_Exit";
            this.pictureBox_Exit.Size = new System.Drawing.Size(41, 41);
            this.pictureBox_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Exit.TabIndex = 31;
            this.pictureBox_Exit.TabStop = false;
            // 
            // label_SoDienThoaiUpdateInput
            // 
            this.label_SoDienThoaiUpdateInput.AutoSize = true;
            this.label_SoDienThoaiUpdateInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_SoDienThoaiUpdateInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoDienThoaiUpdateInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_SoDienThoaiUpdateInput.Location = new System.Drawing.Point(944, 32);
            this.label_SoDienThoaiUpdateInput.Name = "label_SoDienThoaiUpdateInput";
            this.label_SoDienThoaiUpdateInput.Size = new System.Drawing.Size(136, 25);
            this.label_SoDienThoaiUpdateInput.TabIndex = 20;
            this.label_SoDienThoaiUpdateInput.Text = "Số điện thoại *";
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GioiTinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_GioiTinh.Location = new System.Drawing.Point(728, 32);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(97, 25);
            this.label_GioiTinh.TabIndex = 29;
            this.label_GioiTinh.Text = "Giới tính *";
            // 
            // label_ChucVu
            // 
            this.label_ChucVu.AutoSize = true;
            this.label_ChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_ChucVu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChucVu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ChucVu.Location = new System.Drawing.Point(493, 32);
            this.label_ChucVu.Name = "label_ChucVu";
            this.label_ChucVu.Size = new System.Drawing.Size(93, 25);
            this.label_ChucVu.TabIndex = 27;
            this.label_ChucVu.Text = "Chức vụ *";
            // 
            // label_HoVaTenUpdateInput
            // 
            this.label_HoVaTenUpdateInput.AutoSize = true;
            this.label_HoVaTenUpdateInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_HoVaTenUpdateInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoVaTenUpdateInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_HoVaTenUpdateInput.Location = new System.Drawing.Point(174, 32);
            this.label_HoVaTenUpdateInput.Name = "label_HoVaTenUpdateInput";
            this.label_HoVaTenUpdateInput.Size = new System.Drawing.Size(105, 25);
            this.label_HoVaTenUpdateInput.TabIndex = 25;
            this.label_HoVaTenUpdateInput.Text = "Họ và tên *";
            // 
            // label_IDUpdateInput
            // 
            this.label_IDUpdateInput.AutoSize = true;
            this.label_IDUpdateInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_IDUpdateInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDUpdateInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_IDUpdateInput.Location = new System.Drawing.Point(12, 32);
            this.label_IDUpdateInput.Name = "label_IDUpdateInput";
            this.label_IDUpdateInput.Size = new System.Drawing.Size(43, 25);
            this.label_IDUpdateInput.TabIndex = 20;
            this.label_IDUpdateInput.Text = "ID *";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1156, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 48);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label_ChinhSuaThongTinNhanVien
            // 
            this.label_ChinhSuaThongTinNhanVien.AutoSize = true;
            this.label_ChinhSuaThongTinNhanVien.BackColor = System.Drawing.Color.White;
            this.label_ChinhSuaThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChinhSuaThongTinNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.label_ChinhSuaThongTinNhanVien.Location = new System.Drawing.Point(10, 2);
            this.label_ChinhSuaThongTinNhanVien.Name = "label_ChinhSuaThongTinNhanVien";
            this.label_ChinhSuaThongTinNhanVien.Size = new System.Drawing.Size(286, 25);
            this.label_ChinhSuaThongTinNhanVien.TabIndex = 15;
            this.label_ChinhSuaThongTinNhanVien.Text = "Chỉnh sửa Thông tin Nhân viên";
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
            this.panel_SearchFunction.Name = "panel_SearchFunction";
            this.panel_SearchFunction.Size = new System.Drawing.Size(1412, 555);
            this.panel_SearchFunction.TabIndex = 3;
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.dataGridView_ChinhSuaTaiKhoan);
            this.panel_Main.Controls.Add(this.panel_Null3);
            this.panel_Main.Controls.Add(this.panel_ChinhSuaTaiKhoan);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(31, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(1359, 555);
            this.panel_Main.TabIndex = 20;
            // 
            // dataGridView_ChinhSuaTaiKhoan
            // 
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToAddRows = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToDeleteRows = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToResizeColumns = false;
            this.dataGridView_ChinhSuaTaiKhoan.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_ChinhSuaTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersHeight = 40;
            this.dataGridView_ChinhSuaTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_ChinhSuaTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ChinhSuaTaiKhoan.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ChinhSuaTaiKhoan.EnableHeadersVisualStyles = false;
            this.dataGridView_ChinhSuaTaiKhoan.GridColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 89);
            this.dataGridView_ChinhSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_ChinhSuaTaiKhoan.Name = "dataGridView_ChinhSuaTaiKhoan";
            this.dataGridView_ChinhSuaTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersVisible = false;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersWidth = 100;
            this.dataGridView_ChinhSuaTaiKhoan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.dataGridView_ChinhSuaTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_ChinhSuaTaiKhoan.RowTemplate.Height = 24;
            this.dataGridView_ChinhSuaTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(1359, 271);
            this.dataGridView_ChinhSuaTaiKhoan.TabIndex = 0;
            this.dataGridView_ChinhSuaTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ChinhSuaTaiKhoan_CellClick);
            // 
            // panel_Null3
            // 
            this.panel_Null3.Controls.Add(this.txbSearch);
            this.panel_Null3.Controls.Add(this.button_Search);
            this.panel_Null3.Controls.Add(this.label_ThongTinNhanVien);
            this.panel_Null3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Null3.Location = new System.Drawing.Point(0, 0);
            this.panel_Null3.Name = "panel_Null3";
            this.panel_Null3.Size = new System.Drawing.Size(1359, 89);
            this.panel_Null3.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(1204, 40);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(155, 39);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "SEARCH";
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // label_ThongTinNhanVien
            // 
            this.label_ThongTinNhanVien.AutoSize = true;
            this.label_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThongTinNhanVien.Location = new System.Drawing.Point(-5, 3);
            this.label_ThongTinNhanVien.Name = "label_ThongTinNhanVien";
            this.label_ThongTinNhanVien.Size = new System.Drawing.Size(243, 30);
            this.label_ThongTinNhanVien.TabIndex = 6;
            this.label_ThongTinNhanVien.Text = "THÔNG TIN NHÂN VIÊN";
            this.label_ThongTinNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_ChinhSuaTaiKhoan
            // 
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnAdd);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnDelete);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbLuong);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.lbLuong);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbEmail);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.lbEmail);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.DTP_NgayNhanViec);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.cbGioiTinh);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbSoDienThoai);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbHoTen);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.txbIDCapNhat);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.cbChucVu);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_NgayNhanViec);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.pictureBox_Exit);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_SoDienThoaiUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_GioiTinh);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_ChucVu);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_HoVaTenUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_IDUpdateInput);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.btnSave);
            this.panel_ChinhSuaTaiKhoan.Controls.Add(this.label_ChinhSuaThongTinNhanVien);
            this.panel_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 360);
            this.panel_ChinhSuaTaiKhoan.Name = "panel_ChinhSuaTaiKhoan";
            this.panel_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(1359, 195);
            this.panel_ChinhSuaTaiKhoan.TabIndex = 28;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1041, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 48);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(926, 135);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 48);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbLuong
            // 
            this.txbLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLuong.DefaultText = "";
            this.txbLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLuong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLuong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLuong.Location = new System.Drawing.Point(584, 137);
            this.txbLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbLuong.Name = "txbLuong";
            this.txbLuong.PasswordChar = '\0';
            this.txbLuong.PlaceholderText = "";
            this.txbLuong.SelectedText = "";
            this.txbLuong.Size = new System.Drawing.Size(248, 45);
            this.txbLuong.TabIndex = 54;
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbLuong.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLuong.Location = new System.Drawing.Point(584, 107);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(78, 25);
            this.lbLuong.TabIndex = 53;
            this.lbLuong.Text = "Lương *";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbEmail.Location = new System.Drawing.Point(300, 138);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(248, 45);
            this.txbEmail.TabIndex = 52;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmail.Location = new System.Drawing.Point(300, 108);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(71, 25);
            this.lbEmail.TabIndex = 51;
            this.lbEmail.Text = "Email *";
            // 
            // DTP_NgayNhanViec
            // 
            this.DTP_NgayNhanViec.Checked = true;
            this.DTP_NgayNhanViec.FillColor = System.Drawing.Color.White;
            this.DTP_NgayNhanViec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_NgayNhanViec.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DTP_NgayNhanViec.Location = new System.Drawing.Point(16, 138);
            this.DTP_NgayNhanViec.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_NgayNhanViec.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_NgayNhanViec.Name = "DTP_NgayNhanViec";
            this.DTP_NgayNhanViec.Size = new System.Drawing.Size(231, 45);
            this.DTP_NgayNhanViec.TabIndex = 50;
            this.DTP_NgayNhanViec.Value = new System.DateTime(2024, 11, 12, 7, 57, 42, 17);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGioiTinh.ItemHeight = 30;
            this.cbGioiTinh.Location = new System.Drawing.Point(732, 71);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(158, 36);
            this.cbGioiTinh.TabIndex = 49;
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDienThoai.DefaultText = "";
            this.txbSoDienThoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbSoDienThoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbSoDienThoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoDienThoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbSoDienThoai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbSoDienThoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoDienThoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbSoDienThoai.Location = new System.Drawing.Point(948, 61);
            this.txbSoDienThoai.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.PasswordChar = '\0';
            this.txbSoDienThoai.PlaceholderText = "";
            this.txbSoDienThoai.SelectedText = "";
            this.txbSoDienThoai.Size = new System.Drawing.Size(232, 46);
            this.txbSoDienThoai.TabIndex = 48;
            // 
            // txbHoTen
            // 
            this.txbHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbHoTen.DefaultText = "";
            this.txbHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbHoTen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.txbHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbHoTen.Location = new System.Drawing.Point(175, 61);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.PasswordChar = '\0';
            this.txbHoTen.PlaceholderText = "";
            this.txbHoTen.SelectedText = "";
            this.txbHoTen.Size = new System.Drawing.Size(248, 46);
            this.txbHoTen.TabIndex = 46;
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
            this.txbIDCapNhat.Location = new System.Drawing.Point(14, 61);
            this.txbIDCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbIDCapNhat.Name = "txbIDCapNhat";
            this.txbIDCapNhat.PasswordChar = '\0';
            this.txbIDCapNhat.PlaceholderText = "";
            this.txbIDCapNhat.SelectedText = "";
            this.txbIDCapNhat.Size = new System.Drawing.Size(99, 46);
            this.txbIDCapNhat.TabIndex = 45;
            // 
            // cbChucVu
            // 
            this.cbChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChucVu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cbChucVu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucVu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbChucVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbChucVu.ItemHeight = 30;
            this.cbChucVu.Location = new System.Drawing.Point(497, 71);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(161, 36);
            this.cbChucVu.TabIndex = 44;
            // 
            // label_NgayNhanViec
            // 
            this.label_NgayNhanViec.AutoSize = true;
            this.label_NgayNhanViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_NgayNhanViec.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayNhanViec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NgayNhanViec.Location = new System.Drawing.Point(11, 108);
            this.label_NgayNhanViec.Name = "label_NgayNhanViec";
            this.label_NgayNhanViec.Size = new System.Drawing.Size(155, 25);
            this.label_NgayNhanViec.TabIndex = 34;
            this.label_NgayNhanViec.Text = "Ngày nhận việc *";
            // 
            // panel_Null1
            // 
            this.panel_Null1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Null1.Location = new System.Drawing.Point(0, 0);
            this.panel_Null1.Name = "panel_Null1";
            this.panel_Null1.Size = new System.Drawing.Size(31, 555);
            this.panel_Null1.TabIndex = 18;
            // 
            // panel_Null2
            // 
            this.panel_Null2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Null2.Location = new System.Drawing.Point(1390, 0);
            this.panel_Null2.Name = "panel_Null2";
            this.panel_Null2.Size = new System.Drawing.Size(22, 555);
            this.panel_Null2.TabIndex = 19;
            // 
            // quanlycuahangthuocDataSet
            // 
            this.quanlycuahangthuocDataSet.DataSetName = "quanlycuahangthuocDataSet";
            this.quanlycuahangthuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txbSearch.Location = new System.Drawing.Point(0, 39);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.PasswordChar = '\0';
            this.txbSearch.PlaceholderText = "Nhập tên nhân viên";
            this.txbSearch.SelectedText = "";
            this.txbSearch.Size = new System.Drawing.Size(480, 40);
            this.txbSearch.TabIndex = 11;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // fc_EditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 555);
            this.Controls.Add(this.panel_SearchFunction);
            this.Name = "fc_EditStaff";
            this.Text = "fcThemXoaNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Exit)).EndInit();
            this.panel_SearchFunction.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChinhSuaTaiKhoan)).EndInit();
            this.panel_Null3.ResumeLayout(false);
            this.panel_Null3.PerformLayout();
            this.panel_ChinhSuaTaiKhoan.ResumeLayout(false);
            this.panel_ChinhSuaTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycuahangthuocDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_Exit;
        private System.Windows.Forms.Label label_SoDienThoaiUpdateInput;
        private System.Windows.Forms.Label label_GioiTinh;
        private System.Windows.Forms.Label label_ChucVu;
        private System.Windows.Forms.Label label_HoVaTenUpdateInput;
        private System.Windows.Forms.Label label_IDUpdateInput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label_ChinhSuaThongTinNhanVien;
        private System.Windows.Forms.Panel panel_SearchFunction;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.DataGridView dataGridView_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Panel panel_Null3;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_ThongTinNhanVien;
        private System.Windows.Forms.Panel panel_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Label label_NgayNhanViec;
        private System.Windows.Forms.Panel panel_Null1;
        private System.Windows.Forms.Panel panel_Null2;
        private quanlycuahangthuocDataSet quanlycuahangthuocDataSet;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txbSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txbHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txbIDCapNhat;
        private Guna.UI2.WinForms.Guna2ComboBox cbChucVu;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_NgayNhanViec;
        private Guna.UI2.WinForms.Guna2TextBox txbLuong;
        private System.Windows.Forms.Label lbLuong;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txbSearch;
    }
}