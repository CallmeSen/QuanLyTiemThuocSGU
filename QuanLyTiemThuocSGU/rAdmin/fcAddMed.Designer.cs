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
            this.dtpNgayHetHan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbGiaThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTenThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbIDThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.cmbNhaCungCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Checked = true;
            this.dtpNgayHetHan.FillColor = System.Drawing.Color.White;
            this.dtpNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(15, 158);
            this.dtpNgayHetHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHetHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(300, 36);
            this.dtpNgayHetHan.TabIndex = 66;
            this.dtpNgayHetHan.Value = new System.DateTime(2024, 11, 11, 20, 49, 54, 895);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(350, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "Giá thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(350, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 64;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(350, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "ID Thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ngày nhập";
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoLuong.DefaultText = "";
            this.txbSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoLuong.Location = new System.Drawing.Point(353, 93);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.PasswordChar = '\0';
            this.txbSoLuong.PlaceholderText = "Nhập số lượng";
            this.txbSoLuong.SelectedText = "";
            this.txbSoLuong.Size = new System.Drawing.Size(300, 36);
            this.txbSoLuong.TabIndex = 58;
            // 
            // txbGiaThuoc
            // 
            this.txbGiaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbGiaThuoc.DefaultText = "";
            this.txbGiaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbGiaThuoc.Location = new System.Drawing.Point(353, 29);
            this.txbGiaThuoc.Name = "txbGiaThuoc";
            this.txbGiaThuoc.PasswordChar = '\0';
            this.txbGiaThuoc.PlaceholderText = "Nhập giá";
            this.txbGiaThuoc.SelectedText = "";
            this.txbGiaThuoc.Size = new System.Drawing.Size(300, 36);
            this.txbGiaThuoc.TabIndex = 57;
            // 
            // txbTenThuoc
            // 
            this.txbTenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenThuoc.DefaultText = "";
            this.txbTenThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTenThuoc.Location = new System.Drawing.Point(15, 93);
            this.txbTenThuoc.Name = "txbTenThuoc";
            this.txbTenThuoc.PasswordChar = '\0';
            this.txbTenThuoc.PlaceholderText = "Nhập tên";
            this.txbTenThuoc.SelectedText = "";
            this.txbTenThuoc.Size = new System.Drawing.Size(300, 36);
            this.txbTenThuoc.TabIndex = 56;
            // 
            // txbIDThuoc
            // 
            this.txbIDThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDThuoc.DefaultText = "";
            this.txbIDThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbIDThuoc.Location = new System.Drawing.Point(15, 29);
            this.txbIDThuoc.Name = "txbIDThuoc";
            this.txbIDThuoc.PasswordChar = '\0';
            this.txbIDThuoc.PlaceholderText = "Nhập ID";
            this.txbIDThuoc.SelectedText = "";
            this.txbIDThuoc.Size = new System.Drawing.Size(300, 36);
            this.txbIDThuoc.TabIndex = 55;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.Transparent;
            this.btnThemThuoc.BorderRadius = 8;
            this.btnThemThuoc.FillColor = System.Drawing.Color.Green;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemThuoc.ForeColor = System.Drawing.Color.White;
            this.btnThemThuoc.Location = new System.Drawing.Point(503, 296);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(150, 56);
            this.btnThemThuoc.TabIndex = 54;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.cmbNhaCungCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cmbNhaCungCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhaCungCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCungCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.cmbNhaCungCap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhaCungCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNhaCungCap.ItemHeight = 30;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(353, 158);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(300, 36);
            this.cmbNhaCungCap.TabIndex = 67;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(15, 227);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(300, 36);
            this.guna2DateTimePicker1.TabIndex = 69;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 11, 11, 20, 49, 54, 895);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Ngày hết hạn";
            // 
            // fcAddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 364);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNhaCungCap);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbSoLuong);
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
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txbSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txbGiaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbTenThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbIDThuoc;
        private Guna.UI2.WinForms.Guna2Button btnThemThuoc;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNhaCungCap;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}