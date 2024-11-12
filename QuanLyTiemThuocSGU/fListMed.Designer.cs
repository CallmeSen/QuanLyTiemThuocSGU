namespace QuanLyThuVienSGU_Winform
{
    partial class fListMed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInventoryTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddNewItem = new Guna.UI2.WinForms.Guna2Button();
            this.cmbGroupFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnFilterGroup = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvMedList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPaginationInfo = new System.Windows.Forms.Label();
            this.btnPreviousPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInventoryTitle
            // 
            this.lblInventoryTitle.AutoSize = true;
            this.lblInventoryTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblInventoryTitle.Location = new System.Drawing.Point(30, 20);
            this.lblInventoryTitle.Name = "lblInventoryTitle";
            this.lblInventoryTitle.Size = new System.Drawing.Size(369, 30);
            this.lblInventoryTitle.TabIndex = 0;
            this.lblInventoryTitle.Text = "Inventory › List of Medicines (298)";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Location = new System.Drawing.Point(30, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Medicine Inventory...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewItem.BorderRadius = 8;
            this.btnAddNewItem.FillColor = System.Drawing.Color.Red;
            this.btnAddNewItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.Location = new System.Drawing.Point(675, 20);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(125, 36);
            this.btnAddNewItem.TabIndex = 2;
            this.btnAddNewItem.Text = "+ Add New Item";
            // 
            // cmbGroupFilter
            // 
            this.cmbGroupFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbGroupFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGroupFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGroupFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGroupFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGroupFilter.ItemHeight = 30;
            this.cmbGroupFilter.Items.AddRange(new object[] {
            "All Groups",
            "Generic Medicine",
            "Diabetes"});
            this.cmbGroupFilter.Location = new System.Drawing.Point(564, 62);
            this.cmbGroupFilter.Name = "cmbGroupFilter";
            this.cmbGroupFilter.Size = new System.Drawing.Size(150, 36);
            this.cmbGroupFilter.TabIndex = 3;
            // 
            // btnFilterGroup
            // 
            this.btnFilterGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterGroup.BorderRadius = 8;
            this.btnFilterGroup.FillColor = System.Drawing.Color.Gray;
            this.btnFilterGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilterGroup.ForeColor = System.Drawing.Color.White;
            this.btnFilterGroup.Location = new System.Drawing.Point(720, 62);
            this.btnFilterGroup.Name = "btnFilterGroup";
            this.btnFilterGroup.Size = new System.Drawing.Size(80, 36);
            this.btnFilterGroup.TabIndex = 4;
            this.btnFilterGroup.Text = "Filter";
            // 
            // dtgvMedList
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dtgvMedList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvMedList.ColumnHeadersHeight = 15;
            this.dtgvMedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvMedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineID,
            this.MedicineName,
            this.GroupName,
            this.StockInQty});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMedList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvMedList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvMedList.Location = new System.Drawing.Point(30, 110);
            this.dtgvMedList.Name = "dtgvMedList";
            this.dtgvMedList.RowHeadersVisible = false;
            this.dtgvMedList.Size = new System.Drawing.Size(770, 300);
            this.dtgvMedList.TabIndex = 5;
            this.dtgvMedList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvMedList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvMedList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvMedList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvMedList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvMedList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvMedList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvMedList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvMedList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvMedList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvMedList.ThemeStyle.HeaderStyle.Height = 15;
            this.dtgvMedList.ThemeStyle.ReadOnly = false;
            this.dtgvMedList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvMedList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvMedList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvMedList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvMedList.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvMedList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvMedList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MedicineID
            // 
            this.MedicineID.HeaderText = "Medicine ID";
            this.MedicineID.Name = "MedicineID";
            // 
            // MedicineName
            // 
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.Name = "MedicineName";
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Group Name";
            this.GroupName.Name = "GroupName";
            // 
            // StockInQty
            // 
            this.StockInQty.HeaderText = "Quantity";
            this.StockInQty.Name = "StockInQty";
            // 
            // lblPaginationInfo
            // 
            this.lblPaginationInfo.AutoSize = true;
            this.lblPaginationInfo.Location = new System.Drawing.Point(40, 642);
            this.lblPaginationInfo.Name = "lblPaginationInfo";
            this.lblPaginationInfo.Size = new System.Drawing.Size(138, 13);
            this.lblPaginationInfo.TabIndex = 6;
            this.lblPaginationInfo.Text = "Showing 1 - 8 results of 298";
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousPage.BorderRadius = 8;
            this.btnPreviousPage.FillColor = System.Drawing.Color.Gray;
            this.btnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(710, 637);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(40, 36);
            this.btnPreviousPage.TabIndex = 7;
            this.btnPreviousPage.Text = "<";
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BorderRadius = 8;
            this.btnNextPage.FillColor = System.Drawing.Color.Gray;
            this.btnNextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(760, 637);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(40, 36);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = ">";
            // 
            // fListMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 685);
            this.Controls.Add(this.lblInventoryTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.cmbGroupFilter);
            this.Controls.Add(this.btnFilterGroup);
            this.Controls.Add(this.dtgvMedList);
            this.Controls.Add(this.lblPaginationInfo);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnNextPage);
            this.Name = "fListMed";
            this.Text = "Danh sách thuốc";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMedList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInventoryTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddNewItem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGroupFilter;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvMedList;
        private Guna.UI2.WinForms.Guna2Button btnFilterGroup;
        private System.Windows.Forms.Label lblPaginationInfo;
        private Guna.UI2.WinForms.Guna2Button btnPreviousPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockInQty;
    }
}