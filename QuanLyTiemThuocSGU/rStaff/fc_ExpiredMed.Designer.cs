using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace QuanLyThuVienSGU_Winform.rStaff
{
    partial class fc_ExpiredMed
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewExpiredMeds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1037, 50);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1037, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Danh Sách Thuốc Hết Hạn";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewExpiredMeds
            // 
            this.listViewExpiredMeds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewExpiredMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExpiredMeds.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.listViewExpiredMeds.FullRowSelect = true;
            this.listViewExpiredMeds.HideSelection = false;
            this.listViewExpiredMeds.Location = new System.Drawing.Point(0, 50);
            this.listViewExpiredMeds.Name = "listViewExpiredMeds";
            this.listViewExpiredMeds.Size = new System.Drawing.Size(1037, 511);
            this.listViewExpiredMeds.TabIndex = 0;
            this.listViewExpiredMeds.UseCompatibleStateImageBehavior = false;
            this.listViewExpiredMeds.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Thuốc";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Loại Thuốc";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nhà Cung Cấp";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hạn Sử Dụng";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số Lượng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 98;
            // 
            // fc_ExpiredMed
            // 
            this.ClientSize = new System.Drawing.Size(1037, 561);
            this.Controls.Add(this.listViewExpiredMeds);
            this.Controls.Add(this.panelTop);
            this.Name = "fc_ExpiredMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expired Medicines";
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelTop;
        private Label labelTitle;
        private ListView listViewExpiredMeds;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}