namespace QuanLyThuVienSGU_Winform.rAdmin
{
    partial class fc_AddCustomer
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
            this.txbCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemNhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGiaThuoc
            // 
            this.lbGiaThuoc.AutoSize = true;
            this.lbGiaThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaThuoc.Location = new System.Drawing.Point(924, 27);
            this.lbGiaThuoc.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbGiaThuoc.Name = "lbGiaThuoc";
            this.lbGiaThuoc.Size = new System.Drawing.Size(253, 45);
            this.lbGiaThuoc.TabIndex = 80;
            this.lbGiaThuoc.Text = "Tên khách hàng";
            // 
            // txbCustomerName
            // 
            this.txbCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCustomerName.DefaultText = "";
            this.txbCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbCustomerName.Location = new System.Drawing.Point(932, 89);
            this.txbCustomerName.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.txbCustomerName.Name = "txbCustomerName";
            this.txbCustomerName.PasswordChar = '\0';
            this.txbCustomerName.PlaceholderText = "Nhập tên khách hàng";
            this.txbCustomerName.SelectedText = "";
            this.txbCustomerName.Size = new System.Drawing.Size(800, 81);
            this.txbCustomerName.TabIndex = 76;
            // 
            // btnThemNhanvien
            // 
            this.btnThemNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanvien.BorderRadius = 8;
            this.btnThemNhanvien.FillColor = System.Drawing.Color.Green;
            this.btnThemNhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanvien.Location = new System.Drawing.Point(1332, 401);
            this.btnThemNhanvien.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnThemNhanvien.Name = "btnThemNhanvien";
            this.btnThemNhanvien.Size = new System.Drawing.Size(400, 134);
            this.btnThemNhanvien.TabIndex = 74;
            this.btnThemNhanvien.Text = "Thêm khách hàng";
            this.btnThemNhanvien.Click += new System.EventHandler(this.btnThemNhanvien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 45);
            this.label1.TabIndex = 84;
            this.label1.Text = "Số điện thoại";
            // 
            // txbSDT
            // 
            this.txbSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSDT.DefaultText = "Nhập số điện thoại khách hàng";
            this.txbSDT.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(932, 232);
            this.txbSDT.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.PasswordChar = '\0';
            this.txbSDT.PlaceholderText = "Nhập số lượng";
            this.txbSDT.SelectedText = "";
            this.txbSDT.Size = new System.Drawing.Size(800, 81);
            this.txbSDT.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 45);
            this.label2.TabIndex = 86;
            this.label2.Text = "Địa chỉ";
            // 
            // txbAddress
            // 
            this.txbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAddress.DefaultText = "";
            this.txbAddress.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAddress.Location = new System.Drawing.Point(39, 80);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.PasswordChar = '\0';
            this.txbAddress.PlaceholderText = "Nhập địa chỉ khách hàng";
            this.txbAddress.SelectedText = "";
            this.txbAddress.Size = new System.Drawing.Size(800, 81);
            this.txbAddress.TabIndex = 85;
            // 
            // txbEmail
            // 
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.DefaultText = "Nhập email khách hàng";
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(31, 232);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(22, 23, 22, 23);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.PlaceholderText = "Nhập số lượng";
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(800, 81);
            this.txbEmail.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 45);
            this.label3.TabIndex = 88;
            this.label3.Text = "Email";
            // 
            // fc_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.lbGiaThuoc);
            this.Controls.Add(this.txbCustomerName);
            this.Controls.Add(this.btnThemNhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSDT);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "fc_AddCustomer";
            this.Text = "fc_AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label lbGiaThuoc;
        private Guna.UI2.WinForms.Guna2TextBox txbCustomerName;
        private Guna.UI2.WinForms.Guna2Button btnThemNhanvien;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txbSDT;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txbAddress;
        private Guna.UI2.WinForms.Guna2TextBox txbEmail;
        private System.Windows.Forms.Label label3;
    }
}