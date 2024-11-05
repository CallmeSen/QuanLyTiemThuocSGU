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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMedicineList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGenerateBill = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(12, 28);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderText = "Enter Customer Name";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(300, 36);
            this.txtCustomerName.TabIndex = 27;
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerContact.DefaultText = "";
            this.txtCustomerContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerContact.Location = new System.Drawing.Point(366, 28);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.PasswordChar = '\0';
            this.txtCustomerContact.PlaceholderText = "Enter Customer Contact";
            this.txtCustomerContact.SelectedText = "";
            this.txtCustomerContact.Size = new System.Drawing.Size(300, 36);
            this.txtCustomerContact.TabIndex = 28;
            // 
            // dgvMedicineList
            // 
            this.dgvMedicineList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicineList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMedicineList.ColumnHeadersHeight = 15;
            this.dgvMedicineList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicineList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName,
            this.Quantity,
            this.Price,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicineList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicineList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.Location = new System.Drawing.Point(12, 86);
            this.dgvMedicineList.Name = "dgvMedicineList";
            this.dgvMedicineList.RowHeadersVisible = false;
            this.dgvMedicineList.Size = new System.Drawing.Size(1002, 276);
            this.dgvMedicineList.TabIndex = 29;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicineList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicineList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicineList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicineList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
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
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.Name = "MedicineName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMedicine.BorderRadius = 8;
            this.btnAddMedicine.FillColor = System.Drawing.Color.Green;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Location = new System.Drawing.Point(12, 395);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(150, 56);
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
            this.btnRemoveMedicine.Location = new System.Drawing.Point(182, 395);
            this.btnRemoveMedicine.Name = "btnRemoveMedicine";
            this.btnRemoveMedicine.Size = new System.Drawing.Size(150, 56);
            this.btnRemoveMedicine.TabIndex = 31;
            this.btnRemoveMedicine.Text = "Xóa Thuốc";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtotal.Location = new System.Drawing.Point(557, 402);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(83, 19);
            this.lblSubtotal.TabIndex = 32;
            this.lblSubtotal.Text = "Subtotal: $0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTax.Location = new System.Drawing.Point(557, 432);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(50, 19);
            this.lblTax.TabIndex = 33;
            this.lblTax.Text = "Tax: $0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(557, 462);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 19);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total: $0";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateBill.BorderRadius = 8;
            this.btnGenerateBill.FillColor = System.Drawing.Color.Blue;
            this.btnGenerateBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateBill.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBill.Location = new System.Drawing.Point(366, 395);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(150, 56);
            this.btnGenerateBill.TabIndex = 35;
            this.btnGenerateBill.Text = "In Hóa đơn";
            // 
            // fc_SellMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 508);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerContact);
            this.Controls.Add(this.dgvMedicineList);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.btnRemoveMedicine);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGenerateBill);
            this.Name = "fc_SellMed";
            this.Text = "fSellMed";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerContact;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicineList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnRemoveMedicine;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI2.WinForms.Guna2Button btnGenerateBill;
    }
}