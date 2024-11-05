namespace QuanLyThuVienSGU_Winform
{
    partial class fEditMedDetail
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
            this.lblMedicineName = new System.Windows.Forms.Label();
            this.txtMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMedicineID = new System.Windows.Forms.Label();
            this.txtMedicineID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHowToUse = new System.Windows.Forms.Label();
            this.rtbHowToUse = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSideEffects = new System.Windows.Forms.Label();
            this.rtbSideEffects = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // lblMedicineName
            // 
            this.lblMedicineName.AutoSize = true;
            this.lblMedicineName.Location = new System.Drawing.Point(30, 30);
            this.lblMedicineName.Name = "lblMedicineName";
            this.lblMedicineName.Size = new System.Drawing.Size(81, 13);
            this.lblMedicineName.TabIndex = 0;
            this.lblMedicineName.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.DefaultText = "";
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMedicineName.Location = new System.Drawing.Point(150, 30);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PasswordChar = '\0';
            this.txtMedicineName.PlaceholderText = "Enter Medicine Name";
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.Size = new System.Drawing.Size(200, 36);
            this.txtMedicineName.TabIndex = 1;
            // 
            // lblMedicineID
            // 
            this.lblMedicineID.AutoSize = true;
            this.lblMedicineID.Location = new System.Drawing.Point(400, 30);
            this.lblMedicineID.Name = "lblMedicineID";
            this.lblMedicineID.Size = new System.Drawing.Size(64, 13);
            this.lblMedicineID.TabIndex = 2;
            this.lblMedicineID.Text = "Medicine ID";
            // 
            // txtMedicineID
            // 
            this.txtMedicineID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineID.DefaultText = "";
            this.txtMedicineID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMedicineID.Location = new System.Drawing.Point(500, 30);
            this.txtMedicineID.Name = "txtMedicineID";
            this.txtMedicineID.PasswordChar = '\0';
            this.txtMedicineID.PlaceholderText = "Enter Medicine ID";
            this.txtMedicineID.SelectedText = "";
            this.txtMedicineID.Size = new System.Drawing.Size(200, 36);
            this.txtMedicineID.TabIndex = 3;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(30, 80);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(82, 13);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Medicine Group";
            // 
            // cmbGroup
            // 
            this.cmbGroup.BackColor = System.Drawing.Color.Transparent;
            this.cmbGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FocusedColor = System.Drawing.Color.Empty;
            this.cmbGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.ItemHeight = 30;
            this.cmbGroup.Items.AddRange(new object[] {
            "Generic Medicine",
            "Diabetes",
            "Pain Relief"});
            this.cmbGroup.Location = new System.Drawing.Point(150, 80);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 36);
            this.cmbGroup.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(400, 80);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(97, 13);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity in Number";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(500, 80);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "Enter Quantity";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(200, 36);
            this.txtQuantity.TabIndex = 7;
            // 
            // lblHowToUse
            // 
            this.lblHowToUse.AutoSize = true;
            this.lblHowToUse.Location = new System.Drawing.Point(30, 130);
            this.lblHowToUse.Name = "lblHowToUse";
            this.lblHowToUse.Size = new System.Drawing.Size(63, 13);
            this.lblHowToUse.TabIndex = 8;
            this.lblHowToUse.Text = "How to Use";
            // 
            // rtbHowToUse
            // 
            this.rtbHowToUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbHowToUse.DefaultText = "";
            this.rtbHowToUse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbHowToUse.Location = new System.Drawing.Point(150, 130);
            this.rtbHowToUse.Name = "rtbHowToUse";
            this.rtbHowToUse.PasswordChar = '\0';
            this.rtbHowToUse.PlaceholderText = "";
            this.rtbHowToUse.SelectedText = "";
            this.rtbHowToUse.Size = new System.Drawing.Size(550, 60);
            this.rtbHowToUse.TabIndex = 9;
            // 
            // lblSideEffects
            // 
            this.lblSideEffects.AutoSize = true;
            this.lblSideEffects.Location = new System.Drawing.Point(30, 220);
            this.lblSideEffects.Name = "lblSideEffects";
            this.lblSideEffects.Size = new System.Drawing.Size(64, 13);
            this.lblSideEffects.TabIndex = 10;
            this.lblSideEffects.Text = "Side Effects";
            // 
            // rtbSideEffects
            // 
            this.rtbSideEffects.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtbSideEffects.DefaultText = "";
            this.rtbSideEffects.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbSideEffects.Location = new System.Drawing.Point(150, 220);
            this.rtbSideEffects.Name = "rtbSideEffects";
            this.rtbSideEffects.PasswordChar = '\0';
            this.rtbSideEffects.PlaceholderText = "";
            this.rtbSideEffects.SelectedText = "";
            this.rtbSideEffects.Size = new System.Drawing.Size(550, 60);
            this.rtbSideEffects.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Red;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(150, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Details";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fEditMedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMedicineName);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblMedicineID);
            this.Controls.Add(this.txtMedicineID);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblHowToUse);
            this.Controls.Add(this.rtbHowToUse);
            this.Controls.Add(this.lblSideEffects);
            this.Controls.Add(this.rtbSideEffects);
            this.Controls.Add(this.btnSave);
            this.Name = "fEditMedDetail";
            this.Text = "Edit Medicine Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineName;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineID;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGroup;
        private Guna.UI2.WinForms.Guna2TextBox rtbHowToUse;
        private Guna.UI2.WinForms.Guna2TextBox rtbSideEffects;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblMedicineName;
        private System.Windows.Forms.Label lblMedicineID;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblHowToUse;
        private System.Windows.Forms.Label lblSideEffects;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}