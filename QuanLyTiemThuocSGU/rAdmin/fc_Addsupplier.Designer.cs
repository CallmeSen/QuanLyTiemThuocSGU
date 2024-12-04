namespace QuanLyThuVienSGU_Winform.rAdmin
{
    partial class fc_Addsupplier
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
            this.btnThemNhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tsxSupplierName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tsxPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.tsxSuplierEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tsxEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tsxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThemNhanvien
            // 
            this.btnThemNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanvien.BorderRadius = 8;
            this.btnThemNhanvien.FillColor = System.Drawing.Color.Green;
            this.btnThemNhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanvien.Location = new System.Drawing.Point(534, 177);
            this.btnThemNhanvien.Name = "btnThemNhanvien";
            this.btnThemNhanvien.Size = new System.Drawing.Size(150, 56);
            this.btnThemNhanvien.TabIndex = 85;
            this.btnThemNhanvien.Text = "Thêm";
            this.btnThemNhanvien.Click += new System.EventHandler(this.btnThemNhanvien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Supplier name";
            // 
            // tsxSupplierName
            // 
            this.tsxSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tsxSupplierName.DefaultText = "";
            this.tsxSupplierName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsxSupplierName.Location = new System.Drawing.Point(15, 44);
            this.tsxSupplierName.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tsxSupplierName.Name = "tsxSupplierName";
            this.tsxSupplierName.PasswordChar = '\0';
            this.tsxSupplierName.PlaceholderText = "Nhập tên";
            this.tsxSupplierName.SelectedText = "";
            this.tsxSupplierName.Size = new System.Drawing.Size(297, 32);
            this.tsxSupplierName.TabIndex = 89;
            // 
            // tsxPhone
            // 
            this.tsxPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tsxPhone.DefaultText = "";
            this.tsxPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsxPhone.Location = new System.Drawing.Point(387, 44);
            this.tsxPhone.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tsxPhone.Name = "tsxPhone";
            this.tsxPhone.PasswordChar = '\0';
            this.tsxPhone.PlaceholderText = "Nhập số điện thoại";
            this.tsxPhone.SelectedText = "";
            this.tsxPhone.Size = new System.Drawing.Size(297, 32);
            this.tsxPhone.TabIndex = 90;
            // 
            // tsxSuplierEmail
            // 
            this.tsxSuplierEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tsxSuplierEmail.DefaultText = "";
            this.tsxSuplierEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsxSuplierEmail.Location = new System.Drawing.Point(15, 117);
            this.tsxSuplierEmail.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tsxSuplierEmail.Name = "tsxSuplierEmail";
            this.tsxSuplierEmail.PasswordChar = '\0';
            this.tsxSuplierEmail.PlaceholderText = "Nhập email";
            this.tsxSuplierEmail.SelectedText = "";
            this.tsxSuplierEmail.Size = new System.Drawing.Size(297, 32);
            this.tsxSuplierEmail.TabIndex = 91;
            // 
            // tsxEmail
            // 
            this.tsxEmail.AutoSize = true;
            this.tsxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsxEmail.Location = new System.Drawing.Point(12, 89);
            this.tsxEmail.Name = "tsxEmail";
            this.tsxEmail.Size = new System.Drawing.Size(40, 17);
            this.tsxEmail.TabIndex = 92;
            this.tsxEmail.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 93;
            this.label3.Text = "Số Điện Thoại";
            // 
            // tsxAddress
            // 
            this.tsxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tsxAddress.DefaultText = "";
            this.tsxAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsxAddress.Location = new System.Drawing.Point(387, 117);
            this.tsxAddress.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tsxAddress.Name = "tsxAddress";
            this.tsxAddress.PasswordChar = '\0';
            this.tsxAddress.PlaceholderText = "Nhập address";
            this.tsxAddress.SelectedText = "";
            this.tsxAddress.Size = new System.Drawing.Size(297, 32);
            this.tsxAddress.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 95;
            this.label2.Text = "Address";
            // 
            // fc_Addsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tsxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsxEmail);
            this.Controls.Add(this.tsxSuplierEmail);
            this.Controls.Add(this.tsxPhone);
            this.Controls.Add(this.tsxSupplierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemNhanvien);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fc_Addsupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fc_Addsupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThemNhanvien;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tsxSupplierName;
        private Guna.UI2.WinForms.Guna2TextBox tsxPhone;
        private Guna.UI2.WinForms.Guna2TextBox tsxSuplierEmail;
        private System.Windows.Forms.Label tsxEmail;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tsxAddress;
        private System.Windows.Forms.Label label2;
    }
}