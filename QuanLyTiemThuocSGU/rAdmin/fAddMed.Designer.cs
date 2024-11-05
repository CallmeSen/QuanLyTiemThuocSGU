namespace QuanLyThuVienSGU_Winform
{
    partial class fAddMed
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
            this.SuspendLayout();
            // 
            // fAddMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "fAddMed";
            this.Text = "fAddMed";
            this.ResumeLayout(false);
            this.txtMedicineSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.lblAddMedicine = new System.Windows.Forms.Label();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.controlBox = new Guna.UI2.WinForms.Guna2ControlBox();

            this.SuspendLayout();

            // 
            // txtMedicineSearch
            // 
            this.txtMedicineSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineSearch.DefaultText = "";
            this.txtMedicineSearch.Location = new System.Drawing.Point(50, 80);
            this.txtMedicineSearch.Name = "txtMedicineSearch";
            this.txtMedicineSearch.Size = new System.Drawing.Size(300, 36);
            this.txtMedicineSearch.TabIndex = 0;
            this.txtMedicineSearch.PlaceholderText = "Enter Medicine Name or Medicine ID";
            this.txtMedicineSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtMedicineSearch.BorderRadius = 8;

            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMedicine.BorderRadius = 8;
            this.btnAddMedicine.FillColor = System.Drawing.Color.Red;
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Location = new System.Drawing.Point(50, 140);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(300, 36);
            this.btnAddMedicine.TabIndex = 1;
            this.btnAddMedicine.Text = "+ Add Medicine to Group";
            //this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);

            // 
            // lblAddMedicine
            // 
            this.lblAddMedicine.AutoSize = true;
            this.lblAddMedicine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddMedicine.Location = new System.Drawing.Point(50, 20);
            this.lblAddMedicine.Name = "lblAddMedicine";
            this.lblAddMedicine.Size = new System.Drawing.Size(133, 25);
            this.lblAddMedicine.TabIndex = 2;
            this.lblAddMedicine.Text = "Add Medicine";

            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMedicine.Location = new System.Drawing.Point(50, 60);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(67, 19);
            this.lblMedicine.TabIndex = 3;
            this.lblMedicine.Text = "Medicine";

            // 
            // controlBox
            // 
            this.controlBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.controlBox.FillColor = System.Drawing.Color.Transparent;
            this.controlBox.IconColor = System.Drawing.Color.Black;
            this.controlBox.Location = new System.Drawing.Point(350, 10);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(30, 30);
            this.controlBox.TabIndex = 4;

            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.txtMedicineSearch);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.lblAddMedicine);
            this.Controls.Add(this.lblMedicine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Medicine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineSearch;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private System.Windows.Forms.Label lblAddMedicine;
        private System.Windows.Forms.Label lblMedicine;
        private Guna.UI2.WinForms.Guna2ControlBox controlBox;
    }
}