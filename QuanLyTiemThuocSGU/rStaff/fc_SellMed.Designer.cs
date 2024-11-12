namespace QuanLyThuVienSGU_Winform
{
    partial class fc_SellMed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMedicineList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGenerateBill = new Guna.UI2.WinForms.Guna2Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbFindMed = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(333, 492);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderText = "Nhập tên khách hàng";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(300, 36);
            this.txtCustomerName.TabIndex = 27;
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerContact.DefaultText = "";
            this.txtCustomerContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerContact.Location = new System.Drawing.Point(333, 534);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.PasswordChar = '\0';
            this.txtCustomerContact.PlaceholderText = "Nhập SĐT khách hàng";
            this.txtCustomerContact.SelectedText = "";
            this.txtCustomerContact.Size = new System.Drawing.Size(300, 36);
            this.txtCustomerContact.TabIndex = 28;
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicineList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMedicineList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedicineList.ColumnHeadersHeight = 15;
            this.dgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicineList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedicineList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.Location = new System.Drawing.Point(333, 257);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.RowHeadersVisible = false;
            this.dgvMedicineList.Size = new System.Drawing.Size(673, 216);
            this.dgvMedicineList.TabIndex = 29;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicineList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMedicineList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicineList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicineList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicineList.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvMedicineList.ThemeStyle.ReadOnly = false;
            this.dgvMedicineList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicineList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicineList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicineList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMedicineList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMedicine.BorderRadius = 8;
            this.btnAddMedicine.FillColor = System.Drawing.Color.Green;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Location = new System.Drawing.Point(856, 206);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(150, 45);
            this.btnAddMedicine.TabIndex = 30;
            this.btnAddMedicine.Text = "Thêm Thuốc";
            // 
            // btnRemoveMedicine
            // 
            this.btnRemoveMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveMedicine.BorderRadius = 8;
            this.btnRemoveMedicine.FillColor = System.Drawing.Color.Red;
            this.btnRemoveMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveMedicine.ForeColor = System.Drawing.Color.White;
            this.btnRemoveMedicine.Location = new System.Drawing.Point(665, 525);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(150, 45);
            this.btnRemoveMedicine.TabIndex = 31;
            this.btnRemoveMedicine.Text = "Xóa Thuốc";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(663, 498);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 19);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total:";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateBill.BorderRadius = 8;
            this.btnGenerateBill.FillColor = System.Drawing.Color.Blue;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(853, 525);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(150, 45);
            this.btnGenerateBill.TabIndex = 35;
            this.btnGenerateBill.Text = "In Hóa đơn";
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(715, 492);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(258, 25);
            this.txbTotal.TabIndex = 36;
            // 
            // txbFindMed
            // 
            this.txbFindMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbFindMed.DefaultText = "";
            this.txbFindMed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbFindMed.Location = new System.Drawing.Point(12, 35);
            this.txbFindMed.Name = "txbFindMed";
            this.txbFindMed.PasswordChar = '\0';
            this.txbFindMed.PlaceholderText = "Nhập tên thuốc";
            this.txbFindMed.SelectedText = "";
            this.txbFindMed.Size = new System.Drawing.Size(300, 36);
            this.txbFindMed.TabIndex = 37;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.Location = new System.Drawing.Point(368, 35);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Enter Customer Contact";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(300, 36);
            this.guna2TextBox2.TabIndex = 38;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.Location = new System.Drawing.Point(368, 99);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "Enter Customer Contact";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(300, 36);
            this.guna2TextBox3.TabIndex = 39;
            // 
            // guna2TextBox5
            // 
            this.guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox5.DefaultText = "";
            this.guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox5.Location = new System.Drawing.Point(706, 35);
            this.guna2TextBox5.Name = "guna2TextBox5";
            this.guna2TextBox5.PasswordChar = '\0';
            this.guna2TextBox5.PlaceholderText = "Enter Customer Contact";
            this.guna2TextBox5.SelectedText = "";
            this.guna2TextBox5.Size = new System.Drawing.Size(300, 36);
            this.guna2TextBox5.TabIndex = 41;
            // 
            // guna2TextBox6
            // 
            this.guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox6.DefaultText = "";
            this.guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox6.Location = new System.Drawing.Point(706, 99);
            this.guna2TextBox6.Name = "guna2TextBox6";
            this.guna2TextBox6.PasswordChar = '\0';
            this.guna2TextBox6.PlaceholderText = "Enter Customer Contact";
            this.guna2TextBox6.SelectedText = "";
            this.guna2TextBox6.Size = new System.Drawing.Size(300, 36);
            this.guna2TextBox6.TabIndex = 42;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 454);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(207, 77);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(105, 31);
            this.guna2Button1.TabIndex = 45;
            this.guna2Button1.Text = "Tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tìm thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "ID Thuốc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(703, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Giá thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tổng giá";
            // 
            // guna2TextBox7
            // 
            this.guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox7.DefaultText = "";
            this.guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox7.Location = new System.Drawing.Point(706, 164);
            this.guna2TextBox7.Name = "guna2TextBox7";
            this.guna2TextBox7.PasswordChar = '\0';
            this.guna2TextBox7.PlaceholderText = "Enter Customer Contact";
            this.guna2TextBox7.SelectedText = "";
            this.guna2TextBox7.Size = new System.Drawing.Size(300, 36);
            this.guna2TextBox7.TabIndex = 43;
            // 
            // fc_SellMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.guna2TextBox7);
            this.Controls.Add(this.guna2TextBox6);
            this.Controls.Add(this.guna2TextBox5);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.txbFindMed);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerContact);
            this.Controls.Add(this.dgvMedicineList);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnRemoveMedicine);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGenerateBill);
            this.Name = "fc_SellMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSellMed";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerContact;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicineList;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnRemoveMedicine;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnGenerateBill;
        private System.Windows.Forms.TextBox txbTotal;
        private Guna.UI2.WinForms.Guna2TextBox txbFindMed;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox6;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox7;
    }
}