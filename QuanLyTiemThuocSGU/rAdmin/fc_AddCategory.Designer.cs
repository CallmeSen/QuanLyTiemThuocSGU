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
            this.btnThemCategory = new Guna.UI2.WinForms.Guna2Button();
            this.txbCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThemCategory
            // 
            this.btnThemCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnThemCategory.BorderRadius = 8;
            this.btnThemCategory.FillColor = System.Drawing.Color.Green;
            this.btnThemCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemCategory.ForeColor = System.Drawing.Color.White;
            this.btnThemCategory.Location = new System.Drawing.Point(167, 101);
            this.btnThemCategory.Name = "btnThemCategory";
            this.btnThemCategory.Size = new System.Drawing.Size(150, 56);
            this.btnThemCategory.TabIndex = 81;
            this.btnThemCategory.Text = "Thêm category";
            this.btnThemCategory.Click += new System.EventHandler(this.btnThemCategory_Click);
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCategoryName.DefaultText = "";
            this.txbCategoryName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txbCategoryName.Location = new System.Drawing.Point(20, 44);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.PasswordChar = '\0';
            this.txbCategoryName.PlaceholderText = "Nhập category";
            this.txbCategoryName.SelectedText = "";
            this.txbCategoryName.Size = new System.Drawing.Size(297, 32);
            this.txbCategoryName.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tên category";
            // 
            // fc_AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCategoryName);
            this.Controls.Add(this.btnThemCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "fc_AddCategory";
            this.Text = "fc_AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThemCategory;
        private Guna.UI2.WinForms.Guna2TextBox txbCategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}