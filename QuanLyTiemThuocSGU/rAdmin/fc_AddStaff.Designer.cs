namespace QuanLyThuVienSGU_Winform.rAdmin
{
    partial class fc_AddStaff
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
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgayNhanViec = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgayNhanViec = new System.Windows.Forms.Label();
            this.lbGiaThuoc = new System.Windows.Forms.Label();
            this.lbNhomThuoc = new System.Windows.Forms.Label();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.txbSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChucVu.Location = new System.Drawing.Point(304, 99);
            this.cmbChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(260, 28);
            this.cmbChucVu.TabIndex = 86;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.Location = new System.Drawing.Point(14, 99);
            this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(260, 28);
            this.cmbGioiTinh.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Lương";
            // 
            // txbLuong
            // 
            this.txbLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLuong.DefaultText = "";
            this.txbLuong.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLuong.Location = new System.Drawing.Point(304, 170);
            this.txbLuong.Margin = new System.Windows.Forms.Padding(21, 24, 21, 24);
            this.txbLuong.Name = "txbLuong";
            this.txbLuong.PasswordChar = '\0';
            this.txbLuong.PlaceholderText = "Nhập lương";
            this.txbLuong.SelectedText = "";
            this.txbLuong.Size = new System.Drawing.Size(260, 34);
            this.txbLuong.TabIndex = 83;
            // 
            // dtpNgayNhanViec
            // 
            this.dtpNgayNhanViec.Checked = true;
            this.dtpNgayNhanViec.FillColor = System.Drawing.Color.White;
            this.dtpNgayNhanViec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhanViec.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhanViec.Location = new System.Drawing.Point(17, 237);
            this.dtpNgayNhanViec.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dtpNgayNhanViec.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhanViec.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhanViec.Name = "dtpNgayNhanViec";
            this.dtpNgayNhanViec.Size = new System.Drawing.Size(207, 42);
            this.dtpNgayNhanViec.TabIndex = 82;
            this.dtpNgayNhanViec.Value = new System.DateTime(2024, 11, 11, 20, 49, 54, 895);
            // 
            // lbNgayNhanViec
            // 
            this.lbNgayNhanViec.AutoSize = true;
            this.lbNgayNhanViec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhanViec.Location = new System.Drawing.Point(14, 213);
            this.lbNgayNhanViec.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNgayNhanViec.Name = "lbNgayNhanViec";
            this.lbNgayNhanViec.Size = new System.Drawing.Size(102, 17);
            this.lbNgayNhanViec.TabIndex = 81;
            this.lbNgayNhanViec.Text = "Ngày nhận việc";
            // 
            // lbGiaThuoc
            // 
            this.lbGiaThuoc.AutoSize = true;
            this.lbGiaThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThuoc.Location = new System.Drawing.Point(301, 13);
            this.lbGiaThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbGiaThuoc.Name = "lbGiaThuoc";
            this.lbGiaThuoc.Size = new System.Drawing.Size(88, 17);
            this.lbGiaThuoc.TabIndex = 80;
            this.lbGiaThuoc.Text = "Số điện thoại";
            // 
            // lbNhomThuoc
            // 
            this.lbNhomThuoc.AutoSize = true;
            this.lbNhomThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhomThuoc.Location = new System.Drawing.Point(301, 74);
            this.lbNhomThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNhomThuoc.Name = "lbNhomThuoc";
            this.lbNhomThuoc.Size = new System.Drawing.Size(57, 17);
            this.lbNhomThuoc.TabIndex = 79;
            this.lbNhomThuoc.Text = "Chức vụ";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCungCap.Location = new System.Drawing.Point(11, 74);
            this.lbNhaCungCap.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(59, 17);
            this.lbNhaCungCap.TabIndex = 78;
            this.lbNhaCungCap.Text = "Giới tính";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.Location = new System.Drawing.Point(14, 13);
            this.lbTenNhanVien.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(93, 17);
            this.lbTenNhanVien.TabIndex = 77;
            this.lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDienThoai.DefaultText = "";
            this.txbSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbSoDienThoai.Location = new System.Drawing.Point(304, 33);
            this.txbSoDienThoai.Margin = new System.Windows.Forms.Padding(21, 24, 21, 24);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.PasswordChar = '\0';
            this.txbSoDienThoai.PlaceholderText = "Nhập số điện thoại";
            this.txbSoDienThoai.SelectedText = "";
            this.txbSoDienThoai.Size = new System.Drawing.Size(260, 34);
            this.txbSoDienThoai.TabIndex = 76;
            // 
            // txbTenNhanVien
            // 
            this.txbTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenNhanVien.DefaultText = "";
            this.txbTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbTenNhanVien.Location = new System.Drawing.Point(17, 33);
            this.txbTenNhanVien.Margin = new System.Windows.Forms.Padding(21, 24, 21, 24);
            this.txbTenNhanVien.Name = "txbTenNhanVien";
            this.txbTenNhanVien.PasswordChar = '\0';
            this.txbTenNhanVien.PlaceholderText = "Nhập tên";
            this.txbTenNhanVien.SelectedText = "";
            this.txbTenNhanVien.Size = new System.Drawing.Size(257, 34);
            this.txbTenNhanVien.TabIndex = 75;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanVien.BorderRadius = 8;
            this.btnThemNhanVien.FillColor = System.Drawing.Color.Green;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.Location = new System.Drawing.Point(437, 237);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(127, 41);
            this.btnThemNhanVien.TabIndex = 74;
            this.btnThemNhanVien.Text = "Thêm Nhân viên";
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 88;
            this.label2.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "";
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(14, 171);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(21, 24, 21, 24);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "Nhập email";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(260, 34);
            this.txbEmail.TabIndex = 87;
            // 
            // fc_AddStaff
            // 
            this.ClientSize = new System.Drawing.Size(591, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLuong);
            this.Controls.Add(this.dtpNgayNhanViec);
            this.Controls.Add(this.lbNgayNhanViec);
            this.Controls.Add(this.lbGiaThuoc);
            this.Controls.Add(this.lbNhomThuoc);
            this.Controls.Add(this.lbNhaCungCap);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.txbSoDienThoai);
            this.Controls.Add(this.txbTenNhanVien);
            this.Controls.Add(this.btnThemNhanVien);
            this.Name = "fc_AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txbLuong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhanViec;
        private System.Windows.Forms.Label lbNgayNhanViec;
        private System.Windows.Forms.Label lbGiaThuoc;
        private System.Windows.Forms.Label lbNhomThuoc;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txbSoDienThoai;
        private Guna.UI2.WinForms.Guna2TextBox txbTenNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnThemNhanVien;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
    }
}