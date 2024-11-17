namespace QuanLyThuVienSGU_Winform
{
    partial class fc_AddMed
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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.lbGiaThuoc = new System.Windows.Forms.Label();
            this.lbNhomThuoc = new System.Windows.Forms.Label();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbTenThuoc = new System.Windows.Forms.Label();
            this.txbGiaThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dtpNgayHetHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgayHetHan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cmbNhomThuoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbGiaThuoc
            // 
            this.lbGiaThuoc.AutoSize = true;
            this.lbGiaThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThuoc.Location = new System.Drawing.Point(350, 9);
            this.lbGiaThuoc.Name = "lbGiaThuoc";
            this.lbGiaThuoc.Size = new System.Drawing.Size(66, 17);
            this.lbGiaThuoc.TabIndex = 65;
            this.lbGiaThuoc.Text = "Giá thuốc";
            // 
            // lbNhomThuoc
            // 
            this.lbNhomThuoc.AutoSize = true;
            this.lbNhomThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhomThuoc.Location = new System.Drawing.Point(350, 138);
            this.lbNhomThuoc.Name = "lbNhomThuoc";
            this.lbNhomThuoc.Size = new System.Drawing.Size(87, 17);
            this.lbNhomThuoc.TabIndex = 64;
            this.lbNhomThuoc.Text = "Nhóm Thuốc";
            // 
            // lbNhaCungCap
            // 
            this.lbNhaCungCap.AutoSize = true;
            this.lbNhaCungCap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhaCungCap.Location = new System.Drawing.Point(13, 138);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(92, 17);
            this.lbNhaCungCap.TabIndex = 63;
            this.lbNhaCungCap.Text = "Nhà cung cấp";
            // 
            // lbTenThuoc
            // 
            this.lbTenThuoc.AutoSize = true;
            this.lbTenThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThuoc.Location = new System.Drawing.Point(13, 10);
            this.lbTenThuoc.Name = "lbTenThuoc";
            this.lbTenThuoc.Size = new System.Drawing.Size(68, 17);
            this.lbTenThuoc.TabIndex = 61;
            this.lbTenThuoc.Text = "Tên thuốc";
            // 
            // txbGiaThuoc
            // 
            this.txbGiaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGiaThuoc.DefaultText = "";
            this.txbGiaThuoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbGiaThuoc.Location = new System.Drawing.Point(353, 35);
            this.txbGiaThuoc.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbGiaThuoc.Name = "txbGiaThuoc";
            this.txbGiaThuoc.PasswordChar = '\0';
            this.txbGiaThuoc.PlaceholderText = "Nhập giá";
            this.txbGiaThuoc.SelectedText = "";
            this.txbGiaThuoc.Size = new System.Drawing.Size(300, 34);
            this.txbGiaThuoc.TabIndex = 57;
            // 
            // txbTenThuoc
            // 
            this.txbTenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenThuoc.DefaultText = "";
            this.txbTenThuoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbTenThuoc.Location = new System.Drawing.Point(19, 33);
            this.txbTenThuoc.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbTenThuoc.Name = "txbTenThuoc";
            this.txbTenThuoc.PasswordChar = '\0';
            this.txbTenThuoc.PlaceholderText = "Nhập tên";
            this.txbTenThuoc.SelectedText = "";
            this.txbTenThuoc.Size = new System.Drawing.Size(297, 32);
            this.txbTenThuoc.TabIndex = 56;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btnThemThuoc.BorderRadius = 8;
            this.btnThemThuoc.FillColor = System.Drawing.Color.Green;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(502, 216);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(150, 56);
            this.btnThemThuoc.TabIndex = 54;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Checked = true;
            this.dtpNgayHetHan.FillColor = System.Drawing.Color.White;
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(16, 95);
            this.dtpNgayHetHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHetHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(300, 34);
            this.dtpNgayHetHan.TabIndex = 69;
            this.dtpNgayHetHan.Value = new System.DateTime(2024, 11, 11, 20, 49, 54, 895);
            // 
            // lbNgayHetHan
            // 
            this.lbNgayHetHan.AutoSize = true;
            this.lbNgayHetHan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayHetHan.Location = new System.Drawing.Point(13, 75);
            this.lbNgayHetHan.Name = "lbNgayHetHan";
            this.lbNgayHetHan.Size = new System.Drawing.Size(91, 17);
            this.lbNgayHetHan.TabIndex = 68;
            this.lbNgayHetHan.Text = "Ngày hết hạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Số lượng";
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoLuong.DefaultText = "";
            this.txbSoLuong.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSoLuong.Location = new System.Drawing.Point(353, 95);
            this.txbSoLuong.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.PasswordChar = '\0';
            this.txbSoLuong.PlaceholderText = "Nhập số lượng";
            this.txbSoLuong.SelectedText = "";
            this.txbSoLuong.Size = new System.Drawing.Size(300, 34);
            this.txbSoLuong.TabIndex = 70;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(16, 162);
            this.cmbNhaCungCap.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(302, 28);
            this.cmbNhaCungCap.TabIndex = 72;
            // 
            // cmbNhomThuoc
            // 
            this.cmbNhomThuoc.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhomThuoc.FormattingEnabled = true;
            this.cmbNhomThuoc.Location = new System.Drawing.Point(353, 166);
            this.cmbNhomThuoc.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbNhomThuoc.Name = "cmbNhomThuoc";
            this.cmbNhomThuoc.Size = new System.Drawing.Size(302, 28);
            this.cmbNhomThuoc.TabIndex = 73;
            // 
            // fc_AddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 298);
            this.Controls.Add(this.cmbNhomThuoc);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSoLuong);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.lbNgayHetHan);
            this.Controls.Add(this.lbGiaThuoc);
            this.Controls.Add(this.lbNhomThuoc);
            this.Controls.Add(this.lbNhaCungCap);
            this.Controls.Add(this.lbTenThuoc);
            this.Controls.Add(this.txbGiaThuoc);
            this.Controls.Add(this.txbTenThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Name = "fc_AddMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Medicine Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label lbGiaThuoc;
        private System.Windows.Forms.Label lbNhomThuoc;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbTenThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbGiaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbTenThuoc;
        private Guna.UI2.WinForms.Guna2Button btnThemThuoc;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label lbNgayHetHan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txbSoLuong;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.ComboBox cmbNhomThuoc;
    }
}