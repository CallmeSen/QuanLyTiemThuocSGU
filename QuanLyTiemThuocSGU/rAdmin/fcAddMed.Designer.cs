namespace QuanLyThuVienSGU_Winform
{
    partial class fcAddMed
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
            this.dtpNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbGiaThuoc = new System.Windows.Forms.Label();
            this.lbNhomThuoc = new System.Windows.Forms.Label();
            this.lbNhaCungCap = new System.Windows.Forms.Label();
            this.lbThuoc = new System.Windows.Forms.Label();
            this.lbTenThuoc = new System.Windows.Forms.Label();
            this.lbNgayNhap = new System.Windows.Forms.Label();
            this.txbGiaThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.dtpNgayHetHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbNgayHetHan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cmbNhomThuoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Checked = true;
            this.dtpNgayNhap.FillColor = System.Drawing.Color.White;
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayNhap.Location = new System.Drawing.Point(15, 158);
            this.dtpNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(300, 36);
            this.dtpNgayNhap.TabIndex = 66;
            this.dtpNgayNhap.Value = new System.DateTime(2024, 11, 11, 20, 49, 54, 895);
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
            this.lbNhaCungCap.Location = new System.Drawing.Point(350, 203);
            this.lbNhaCungCap.Name = "lbNhaCungCap";
            this.lbNhaCungCap.Size = new System.Drawing.Size(92, 17);
            this.lbNhaCungCap.TabIndex = 63;
            this.lbNhaCungCap.Text = "Nhà cung cấp";
            // 
            // lbThuoc
            // 
            this.lbThuoc.AutoSize = true;
            this.lbThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuoc.Location = new System.Drawing.Point(12, 9);
            this.lbThuoc.Name = "lbThuoc";
            this.lbThuoc.Size = new System.Drawing.Size(62, 17);
            this.lbThuoc.TabIndex = 62;
            this.lbThuoc.Text = "ID Thuốc";
            // 
            // lbTenThuoc
            // 
            this.lbTenThuoc.AutoSize = true;
            this.lbTenThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenThuoc.Location = new System.Drawing.Point(12, 73);
            this.lbTenThuoc.Name = "lbTenThuoc";
            this.lbTenThuoc.Size = new System.Drawing.Size(68, 17);
            this.lbTenThuoc.TabIndex = 61;
            this.lbTenThuoc.Text = "Tên thuốc";
            // 
            // lbNgayNhap
            // 
            this.lbNgayNhap.AutoSize = true;
            this.lbNgayNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayNhap.Location = new System.Drawing.Point(12, 138);
            this.lbNgayNhap.Name = "lbNgayNhap";
            this.lbNgayNhap.Size = new System.Drawing.Size(75, 17);
            this.lbNgayNhap.TabIndex = 60;
            this.lbNgayNhap.Text = "Ngày nhập";
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
            this.txbTenThuoc.Location = new System.Drawing.Point(18, 95);
            this.txbTenThuoc.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbTenThuoc.Name = "txbTenThuoc";
            this.txbTenThuoc.PasswordChar = '\0';
            this.txbTenThuoc.PlaceholderText = "Nhập tên";
            this.txbTenThuoc.SelectedText = "";
            this.txbTenThuoc.Size = new System.Drawing.Size(297, 34);
            this.txbTenThuoc.TabIndex = 56;
            // 
            // txbIDThuoc
            // 
            this.txbIDThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDThuoc.DefaultText = "";
            this.txbIDThuoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbIDThuoc.Location = new System.Drawing.Point(18, 35);
            this.txbIDThuoc.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbIDThuoc.Name = "txbIDThuoc";
            this.txbIDThuoc.PasswordChar = '\0';
            this.txbIDThuoc.PlaceholderText = "Nhập ID";
            this.txbIDThuoc.SelectedText = "";
            this.txbIDThuoc.Size = new System.Drawing.Size(297, 34);
            this.txbIDThuoc.TabIndex = 55;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btnThemThuoc.BorderRadius = 8;
            this.btnThemThuoc.FillColor = System.Drawing.Color.Green;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(503, 273);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(150, 56);
            this.btnThemThuoc.TabIndex = 54;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Checked = true;
            this.dtpNgayHetHan.FillColor = System.Drawing.Color.White;
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(15, 227);
            this.dtpNgayHetHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHetHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(300, 36);
            this.dtpNgayHetHan.TabIndex = 69;
            this.dtpNgayHetHan.Value = new System.DateTime(2024, 11, 11, 20, 49, 54, 895);
            // 
            // lbNgayHetHan
            // 
            this.lbNgayHetHan.AutoSize = true;
            this.lbNgayHetHan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayHetHan.Location = new System.Drawing.Point(12, 207);
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
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.Location = new System.Drawing.Point(353, 95);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Nhập số lượng";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(300, 34);
            this.guna2TextBox1.TabIndex = 70;
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(353, 227);
            this.cmbNhaCungCap.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(302, 28);
            this.cmbNhaCungCap.TabIndex = 72;
            this.cmbNhaCungCap.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // cmbNhomThuoc
            // 
            this.cmbNhomThuoc.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhomThuoc.FormattingEnabled = true;
            this.cmbNhomThuoc.Location = new System.Drawing.Point(353, 166);
            this.cmbNhomThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.cmbNhomThuoc.Name = "cmbNhomThuoc";
            this.cmbNhomThuoc.Size = new System.Drawing.Size(302, 28);
            this.cmbNhomThuoc.TabIndex = 73;
            // 
            // fcAddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 353);
            this.Controls.Add(this.cmbNhomThuoc);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.lbNgayHetHan);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.lbGiaThuoc);
            this.Controls.Add(this.lbNhomThuoc);
            this.Controls.Add(this.lbNhaCungCap);
            this.Controls.Add(this.lbThuoc);
            this.Controls.Add(this.lbTenThuoc);
            this.Controls.Add(this.lbNgayNhap);
            this.Controls.Add(this.txbGiaThuoc);
            this.Controls.Add(this.txbTenThuoc);
            this.Controls.Add(this.txbIDThuoc);
            this.Controls.Add(this.btnThemThuoc);
            this.Name = "fcAddMed";
            this.Text = "Edit Medicine Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lbGiaThuoc;
        private System.Windows.Forms.Label lbNhomThuoc;
        private System.Windows.Forms.Label lbNhaCungCap;
        private System.Windows.Forms.Label lbThuoc;
        private System.Windows.Forms.Label lbTenThuoc;
        private System.Windows.Forms.Label lbNgayNhap;
        private Guna.UI2.WinForms.Guna2TextBox txbGiaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbTenThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbIDThuoc;
        private Guna.UI2.WinForms.Guna2Button btnThemThuoc;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label lbNgayHetHan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.ComboBox cmbNhomThuoc;
    }
}