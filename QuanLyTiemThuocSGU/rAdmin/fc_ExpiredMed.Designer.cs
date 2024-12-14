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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DanhSachThuocHetHan = new System.Windows.Forms.DataGridView();
            this.dataGridView_DanhSachThuocSapHet = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachThuocHetHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachThuocSapHet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1316, 56);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(655, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(672, 56);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Danh Sách Thuốc Hết Hạn";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Thuốc Sắp Hết";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_DanhSachThuocHetHan
            // 
            this.dataGridView_DanhSachThuocHetHan.AllowUserToAddRows = false;
            this.dataGridView_DanhSachThuocHetHan.AllowUserToDeleteRows = false;
            this.dataGridView_DanhSachThuocHetHan.AllowUserToResizeColumns = false;
            this.dataGridView_DanhSachThuocHetHan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocHetHan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_DanhSachThuocHetHan.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocHetHan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DanhSachThuocHetHan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_DanhSachThuocHetHan.ColumnHeadersHeight = 40;
            this.dataGridView_DanhSachThuocHetHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_DanhSachThuocHetHan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DanhSachThuocHetHan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_DanhSachThuocHetHan.EnableHeadersVisualStyles = false;
            this.dataGridView_DanhSachThuocHetHan.GridColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocHetHan.Location = new System.Drawing.Point(662, 60);
            this.dataGridView_DanhSachThuocHetHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_DanhSachThuocHetHan.Name = "dataGridView_DanhSachThuocHetHan";
            this.dataGridView_DanhSachThuocHetHan.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DanhSachThuocHetHan.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_DanhSachThuocHetHan.RowHeadersVisible = false;
            this.dataGridView_DanhSachThuocHetHan.RowHeadersWidth = 100;
            this.dataGridView_DanhSachThuocHetHan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.dataGridView_DanhSachThuocHetHan.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_DanhSachThuocHetHan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_DanhSachThuocHetHan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocHetHan.RowTemplate.Height = 24;
            this.dataGridView_DanhSachThuocHetHan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DanhSachThuocHetHan.Size = new System.Drawing.Size(642, 638);
            this.dataGridView_DanhSachThuocHetHan.TabIndex = 2;
            // 
            // dataGridView_DanhSachThuocSapHet
            // 
            this.dataGridView_DanhSachThuocSapHet.AllowUserToAddRows = false;
            this.dataGridView_DanhSachThuocSapHet.AllowUserToDeleteRows = false;
            this.dataGridView_DanhSachThuocSapHet.AllowUserToResizeColumns = false;
            this.dataGridView_DanhSachThuocSapHet.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocSapHet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_DanhSachThuocSapHet.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocSapHet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DanhSachThuocSapHet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_DanhSachThuocSapHet.ColumnHeadersHeight = 40;
            this.dataGridView_DanhSachThuocSapHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_DanhSachThuocSapHet.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_DanhSachThuocSapHet.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_DanhSachThuocSapHet.EnableHeadersVisualStyles = false;
            this.dataGridView_DanhSachThuocSapHet.GridColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocSapHet.Location = new System.Drawing.Point(0, 60);
            this.dataGridView_DanhSachThuocSapHet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_DanhSachThuocSapHet.Name = "dataGridView_DanhSachThuocSapHet";
            this.dataGridView_DanhSachThuocSapHet.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_DanhSachThuocSapHet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_DanhSachThuocSapHet.RowHeadersVisible = false;
            this.dataGridView_DanhSachThuocSapHet.RowHeadersWidth = 100;
            this.dataGridView_DanhSachThuocSapHet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.dataGridView_DanhSachThuocSapHet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_DanhSachThuocSapHet.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_DanhSachThuocSapHet.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_DanhSachThuocSapHet.RowTemplate.Height = 24;
            this.dataGridView_DanhSachThuocSapHet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DanhSachThuocSapHet.Size = new System.Drawing.Size(656, 638);
            this.dataGridView_DanhSachThuocSapHet.TabIndex = 3;
            // 
            // fc_ExpiredMed
            // 
            this.ClientSize = new System.Drawing.Size(1316, 711);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dataGridView_DanhSachThuocHetHan);
            this.Controls.Add(this.dataGridView_DanhSachThuocSapHet);
            this.Name = "fc_ExpiredMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expired Medicines";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachThuocHetHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DanhSachThuocSapHet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelTop;
        private Label labelTitle;
        private Label label1;
        private DataGridView dataGridView_DanhSachThuocHetHan;
        private DataGridView dataGridView_DanhSachThuocSapHet;
    }
}