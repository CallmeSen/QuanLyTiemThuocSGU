namespace QuanLyThuVienSGU_Winform.rAdmin
{
    partial class fc_AddCategory
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
            this.lbKhachhang = new System.Windows.Forms.Label();
            this.txbCategoryId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemNhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.txbCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbKhachhang
            // 
            this.lbKhachhang.AutoSize = true;
            this.lbKhachhang.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhachhang.Location = new System.Drawing.Point(13, 31);
            this.lbKhachhang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhachhang.Name = "lbKhachhang";
            this.lbKhachhang.Size = new System.Drawing.Size(103, 23);
            this.lbKhachhang.TabIndex = 84;
            this.lbKhachhang.Text = "Category ID";
            this.lbKhachhang.Click += new System.EventHandler(this.lbKhachhang_Click);
            // 
            // txbCategoryId
            // 
            this.txbCategoryId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCategoryId.DefaultText = "";
            this.txbCategoryId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbCategoryId.Location = new System.Drawing.Point(17, 63);
            this.txbCategoryId.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txbCategoryId.Name = "txbCategoryId";
            this.txbCategoryId.PasswordChar = '\0';
            this.txbCategoryId.PlaceholderText = "Nhập ID";
            this.txbCategoryId.SelectedText = "";
            this.txbCategoryId.Size = new System.Drawing.Size(396, 39);
            this.txbCategoryId.TabIndex = 82;
            // 
            // btnThemNhanvien
            // 
            this.btnThemNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btnThemNhanvien.BorderRadius = 8;
            this.btnThemNhanvien.FillColor = System.Drawing.Color.Green;
            this.btnThemNhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanvien.Location = new System.Drawing.Point(816, 182);
            this.btnThemNhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemNhanvien.Name = "btnThemNhanvien";
            this.btnThemNhanvien.Size = new System.Drawing.Size(200, 69);
            this.btnThemNhanvien.TabIndex = 81;
            this.btnThemNhanvien.Text = "Thêm category";
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCategoryName.DefaultText = "";
            this.txbCategoryName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbCategoryName.Location = new System.Drawing.Point(521, 63);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.PasswordChar = '\0';
            this.txbCategoryName.PlaceholderText = "Nhập category";
            this.txbCategoryName.SelectedText = "";
            this.txbCategoryName.Size = new System.Drawing.Size(396, 39);
            this.txbCategoryName.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tên category";
            // 
            // fc_AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCategoryName);
            this.Controls.Add(this.lbKhachhang);
            this.Controls.Add(this.txbCategoryId);
            this.Controls.Add(this.btnThemNhanvien);
            this.Name = "fc_AddCategory";
            this.Text = "fc_AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbKhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txbCategoryId;
        private Guna.UI2.WinForms.Guna2Button btnThemNhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txbCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}