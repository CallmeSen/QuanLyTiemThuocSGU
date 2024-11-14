namespace QuanLyThuVienSGU_Winform
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.panel_Search = new System.Windows.Forms.Panel();
            this.pictureBox_SearchIcon = new System.Windows.Forms.PictureBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label_CurrentFunction = new System.Windows.Forms.Label();
            this.label_CurrentPage = new System.Windows.Forms.Label();
            this.label_DecorLine = new System.Windows.Forms.Label();
            this.label_Home = new System.Windows.Forms.Label();
            this.button_QuanLiThuoc = new System.Windows.Forms.Button();
            this.button_XepLichLamViec = new System.Windows.Forms.Button();
            this.panel_ChildTaiKhoanNhanVien = new System.Windows.Forms.Panel();
            this.button_ChinhSuaTaiKhoan = new System.Windows.Forms.Button();
            this.button_Thongtin = new System.Windows.Forms.Button();
            this.button_QuanLiNhanVien = new System.Windows.Forms.Button();
            this.panel_ChildQuanLiThuoc = new System.Windows.Forms.Panel();
            this.button_ChinhSuaThuoc = new System.Windows.Forms.Button();
            this.button_ThongTinThuoc = new System.Windows.Forms.Button();
            this.timer_TaiKhoanNhanVienTransition = new System.Windows.Forms.Timer(this.components);
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.panel_ChildQuanLiNhomThuoc = new System.Windows.Forms.Panel();
            this.button_ChinhSuaNhanVien = new System.Windows.Forms.Button();
            this.button_ThongTinNhanVien = new System.Windows.Forms.Button();
            this.timer_QuanLiThuocTransition = new System.Windows.Forms.Timer(this.components);
            this.timer_QuanLiNhomThuocTransition = new System.Windows.Forms.Timer(this.components);
            this.button_TaiKhoanNhanVien = new System.Windows.Forms.Button();
            this.panel_LogoUeh = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer_SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Sidebar = new System.Windows.Forms.Panel();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SearchIcon)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.panel_ChildTaiKhoanNhanVien.SuspendLayout();
            this.panel_ChildQuanLiThuoc.SuspendLayout();
            this.panel_ChildQuanLiNhomThuoc.SuspendLayout();
            this.panel_LogoUeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel_Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.pictureBox_SearchIcon);
            this.panel_Search.Controls.Add(this.label_Search);
            this.panel_Search.Controls.Add(this.textBox_Search);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Search.Location = new System.Drawing.Point(579, 141);
            this.panel_Search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(3106, 119);
            this.panel_Search.TabIndex = 5;
            // 
            // pictureBox_SearchIcon
            // 
            this.pictureBox_SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SearchIcon.Image")));
            this.pictureBox_SearchIcon.Location = new System.Drawing.Point(72, 33);
            this.pictureBox_SearchIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox_SearchIcon.Name = "pictureBox_SearchIcon";
            this.pictureBox_SearchIcon.Size = new System.Drawing.Size(80, 64);
            this.pictureBox_SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SearchIcon.TabIndex = 2;
            this.pictureBox_SearchIcon.TabStop = false;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.ForeColor = System.Drawing.Color.Gray;
            this.label_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_Search.Location = new System.Drawing.Point(165, 45);
            this.label_Search.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(147, 46);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Search";
            // 
            // textBox_Search
            // 
            this.textBox_Search.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(160, 36);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(901, 64);
            this.textBox_Search.TabIndex = 0;
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.label_CurrentFunction);
            this.panel_Info.Controls.Add(this.label_CurrentPage);
            this.panel_Info.Controls.Add(this.label_DecorLine);
            this.panel_Info.Controls.Add(this.label_Home);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(579, 0);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(3106, 141);
            this.panel_Info.TabIndex = 6;
            // 
            // label_CurrentFunction
            // 
            this.label_CurrentFunction.AutoSize = true;
            this.label_CurrentFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CurrentFunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.label_CurrentFunction.Location = new System.Drawing.Point(184, 69);
            this.label_CurrentFunction.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_CurrentFunction.Name = "label_CurrentFunction";
            this.label_CurrentFunction.Size = new System.Drawing.Size(0, 54);
            this.label_CurrentFunction.TabIndex = 3;
            this.label_CurrentFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_CurrentPage
            // 
            this.label_CurrentPage.AutoSize = true;
            this.label_CurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentPage.ForeColor = System.Drawing.Color.Black;
            this.label_CurrentPage.Location = new System.Drawing.Point(51, 2);
            this.label_CurrentPage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_CurrentPage.Name = "label_CurrentPage";
            this.label_CurrentPage.Size = new System.Drawing.Size(156, 65);
            this.label_CurrentPage.TabIndex = 0;
            this.label_CurrentPage.Text = "Pages";
            // 
            // label_DecorLine
            // 
            this.label_DecorLine.AutoSize = true;
            this.label_DecorLine.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DecorLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.label_DecorLine.Location = new System.Drawing.Point(48, 5);
            this.label_DecorLine.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_DecorLine.Name = "label_DecorLine";
            this.label_DecorLine.Size = new System.Drawing.Size(158, 73);
            this.label_DecorLine.TabIndex = 2;
            this.label_DecorLine.Text = "_______";
            // 
            // label_Home
            // 
            this.label_Home.AutoSize = true;
            this.label_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home.ForeColor = System.Drawing.Color.Black;
            this.label_Home.Location = new System.Drawing.Point(51, 69);
            this.label_Home.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(140, 54);
            this.label_Home.TabIndex = 1;
            this.label_Home.Text = "Home ";
            // 
            // button_QuanLiThuoc
            // 
            this.button_QuanLiThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QuanLiThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_QuanLiThuoc.FlatAppearance.BorderSize = 0;
            this.button_QuanLiThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuanLiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLiThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_QuanLiThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiThuoc.Location = new System.Drawing.Point(0, 736);
            this.button_QuanLiThuoc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_QuanLiThuoc.Name = "button_QuanLiThuoc";
            this.button_QuanLiThuoc.Size = new System.Drawing.Size(579, 119);
            this.button_QuanLiThuoc.TabIndex = 8;
            this.button_QuanLiThuoc.Text = "           Quản lý thuốc";
            this.button_QuanLiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiThuoc.UseVisualStyleBackColor = true;
            this.button_QuanLiThuoc.Click += new System.EventHandler(this.button_QuanLiThuoc_Click);
            // 
            // button_XepLichLamViec
            // 
            this.button_XepLichLamViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_XepLichLamViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_XepLichLamViec.FlatAppearance.BorderSize = 0;
            this.button_XepLichLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XepLichLamViec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XepLichLamViec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_XepLichLamViec.Image = ((System.Drawing.Image)(resources.GetObject("button_XepLichLamViec.Image")));
            this.button_XepLichLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_XepLichLamViec.Location = new System.Drawing.Point(0, 617);
            this.button_XepLichLamViec.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_XepLichLamViec.Name = "button_XepLichLamViec";
            this.button_XepLichLamViec.Size = new System.Drawing.Size(579, 119);
            this.button_XepLichLamViec.TabIndex = 7;
            this.button_XepLichLamViec.Text = "          Xếp lịch làm việc";
            this.button_XepLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_XepLichLamViec.UseVisualStyleBackColor = true;
            // 
            // panel_ChildTaiKhoanNhanVien
            // 
            this.panel_ChildTaiKhoanNhanVien.Controls.Add(this.button_ChinhSuaTaiKhoan);
            this.panel_ChildTaiKhoanNhanVien.Controls.Add(this.button_Thongtin);
            this.panel_ChildTaiKhoanNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildTaiKhoanNhanVien.Location = new System.Drawing.Point(0, 379);
            this.panel_ChildTaiKhoanNhanVien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_ChildTaiKhoanNhanVien.Name = "panel_ChildTaiKhoanNhanVien";
            this.panel_ChildTaiKhoanNhanVien.Size = new System.Drawing.Size(579, 238);
            this.panel_ChildTaiKhoanNhanVien.TabIndex = 6;
            // 
            // button_ChinhSuaTaiKhoan
            // 
            this.button_ChinhSuaTaiKhoan.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ChinhSuaTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChinhSuaTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ChinhSuaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.button_ChinhSuaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSuaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ChinhSuaTaiKhoan.Location = new System.Drawing.Point(0, 119);
            this.button_ChinhSuaTaiKhoan.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ChinhSuaTaiKhoan.Name = "button_ChinhSuaTaiKhoan";
            this.button_ChinhSuaTaiKhoan.Size = new System.Drawing.Size(579, 119);
            this.button_ChinhSuaTaiKhoan.TabIndex = 1;
            this.button_ChinhSuaTaiKhoan.Text = "           > Chỉnh sửa tài khoản";
            this.button_ChinhSuaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ChinhSuaTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // button_Thongtin
            // 
            this.button_Thongtin.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Thongtin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Thongtin.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Thongtin.FlatAppearance.BorderSize = 0;
            this.button_Thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Thongtin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_Thongtin.Location = new System.Drawing.Point(0, 0);
            this.button_Thongtin.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_Thongtin.Name = "button_Thongtin";
            this.button_Thongtin.Size = new System.Drawing.Size(579, 119);
            this.button_Thongtin.TabIndex = 0;
            this.button_Thongtin.Text = "           > Thông tin";
            this.button_Thongtin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Thongtin.UseVisualStyleBackColor = false;
            this.button_Thongtin.Click += new System.EventHandler(this.button_Thongtin_Click);
            // 
            // button_QuanLiNhanVien
            // 
            this.button_QuanLiNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QuanLiNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_QuanLiNhanVien.FlatAppearance.BorderSize = 0;
            this.button_QuanLiNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuanLiNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLiNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_QuanLiNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiNhanVien.Location = new System.Drawing.Point(0, 1093);
            this.button_QuanLiNhanVien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_QuanLiNhanVien.Name = "button_QuanLiNhanVien";
            this.button_QuanLiNhanVien.Size = new System.Drawing.Size(579, 119);
            this.button_QuanLiNhanVien.TabIndex = 10;
            this.button_QuanLiNhanVien.Text = "          Quản lí nhân viên";
            this.button_QuanLiNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiNhanVien.UseVisualStyleBackColor = true;
            this.button_QuanLiNhanVien.Click += new System.EventHandler(this.button_QuanLiNhomThuoc_Click);
            // 
            // panel_ChildQuanLiThuoc
            // 
            this.panel_ChildQuanLiThuoc.Controls.Add(this.button_ChinhSuaThuoc);
            this.panel_ChildQuanLiThuoc.Controls.Add(this.button_ThongTinThuoc);
            this.panel_ChildQuanLiThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildQuanLiThuoc.Location = new System.Drawing.Point(0, 855);
            this.panel_ChildQuanLiThuoc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_ChildQuanLiThuoc.Name = "panel_ChildQuanLiThuoc";
            this.panel_ChildQuanLiThuoc.Size = new System.Drawing.Size(579, 238);
            this.panel_ChildQuanLiThuoc.TabIndex = 11;
            // 
            // button_ChinhSuaThuoc
            // 
            this.button_ChinhSuaThuoc.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ChinhSuaThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChinhSuaThuoc.FlatAppearance.BorderSize = 0;
            this.button_ChinhSuaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSuaThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ChinhSuaThuoc.Location = new System.Drawing.Point(0, 119);
            this.button_ChinhSuaThuoc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ChinhSuaThuoc.Name = "button_ChinhSuaThuoc";
            this.button_ChinhSuaThuoc.Size = new System.Drawing.Size(579, 119);
            this.button_ChinhSuaThuoc.TabIndex = 1;
            this.button_ChinhSuaThuoc.Text = "           > Chỉnh sửa thuốc\r\n";
            this.button_ChinhSuaThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ChinhSuaThuoc.UseVisualStyleBackColor = false;
            // 
            // button_ThongTinThuoc
            // 
            this.button_ThongTinThuoc.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ThongTinThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThongTinThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ThongTinThuoc.FlatAppearance.BorderSize = 0;
            this.button_ThongTinThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongTinThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongTinThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ThongTinThuoc.Location = new System.Drawing.Point(0, 0);
            this.button_ThongTinThuoc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ThongTinThuoc.Name = "button_ThongTinThuoc";
            this.button_ThongTinThuoc.Size = new System.Drawing.Size(579, 119);
            this.button_ThongTinThuoc.TabIndex = 0;
            this.button_ThongTinThuoc.Text = "           > Thông tin thuốc ";
            this.button_ThongTinThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongTinThuoc.UseVisualStyleBackColor = false;
            this.button_ThongTinThuoc.Click += new System.EventHandler(this.button_ThongTinThuoc_Click);
            // 
            // timer_TaiKhoanNhanVienTransition
            // 
            this.timer_TaiKhoanNhanVienTransition.Interval = 10;
            this.timer_TaiKhoanNhanVienTransition.Tick += new System.EventHandler(this.timer_TaiKhoanNhanVienTransition_Tick);
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ThongKe.FlatAppearance.BorderSize = 0;
            this.button_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("button_ThongKe.Image")));
            this.button_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongKe.Location = new System.Drawing.Point(0, 1450);
            this.button_ThongKe.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(579, 119);
            this.button_ThongKe.TabIndex = 12;
            this.button_ThongKe.Text = "          Thống kê";
            this.button_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongKe.UseVisualStyleBackColor = true;
            // 
            // panel_ChildQuanLiNhomThuoc
            // 
            this.panel_ChildQuanLiNhomThuoc.Controls.Add(this.button_ChinhSuaNhanVien);
            this.panel_ChildQuanLiNhomThuoc.Controls.Add(this.button_ThongTinNhanVien);
            this.panel_ChildQuanLiNhomThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildQuanLiNhomThuoc.Location = new System.Drawing.Point(0, 1212);
            this.panel_ChildQuanLiNhomThuoc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_ChildQuanLiNhomThuoc.Name = "panel_ChildQuanLiNhomThuoc";
            this.panel_ChildQuanLiNhomThuoc.Size = new System.Drawing.Size(579, 238);
            this.panel_ChildQuanLiNhomThuoc.TabIndex = 12;
            // 
            // button_ChinhSuaNhanVien
            // 
            this.button_ChinhSuaNhanVien.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ChinhSuaNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChinhSuaNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ChinhSuaNhanVien.FlatAppearance.BorderSize = 0;
            this.button_ChinhSuaNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSuaNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ChinhSuaNhanVien.Location = new System.Drawing.Point(0, 119);
            this.button_ChinhSuaNhanVien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ChinhSuaNhanVien.Name = "button_ChinhSuaNhanVien";
            this.button_ChinhSuaNhanVien.Size = new System.Drawing.Size(579, 119);
            this.button_ChinhSuaNhanVien.TabIndex = 16;
            this.button_ChinhSuaNhanVien.Text = "          > Chỉnh sửa nhân viên\r\n";
            this.button_ChinhSuaNhanVien.UseVisualStyleBackColor = false;
            // 
            // button_ThongTinNhanVien
            // 
            this.button_ThongTinNhanVien.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ThongTinNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThongTinNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ThongTinNhanVien.FlatAppearance.BorderSize = 0;
            this.button_ThongTinNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongTinNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ThongTinNhanVien.Location = new System.Drawing.Point(0, 0);
            this.button_ThongTinNhanVien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_ThongTinNhanVien.Name = "button_ThongTinNhanVien";
            this.button_ThongTinNhanVien.Size = new System.Drawing.Size(579, 119);
            this.button_ThongTinNhanVien.TabIndex = 15;
            this.button_ThongTinNhanVien.Text = "          > Thông tin nhân viên";
            this.button_ThongTinNhanVien.UseVisualStyleBackColor = false;
            this.button_ThongTinNhanVien.Click += new System.EventHandler(this.button_ThongTinNhomThuoc_Click);
            // 
            // timer_QuanLiThuocTransition
            // 
            this.timer_QuanLiThuocTransition.Interval = 10;
            this.timer_QuanLiThuocTransition.Tick += new System.EventHandler(this.timer_QuanLiThuocTransition_Tick);
            // 
            // timer_QuanLiNhomThuocTransition
            // 
            this.timer_QuanLiNhomThuocTransition.Interval = 10;
            this.timer_QuanLiNhomThuocTransition.Tick += new System.EventHandler(this.timer_QuanLiNhomThuocTransition_Tick);
            // 
            // button_TaiKhoanNhanVien
            // 
            this.button_TaiKhoanNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TaiKhoanNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_TaiKhoanNhanVien.FlatAppearance.BorderSize = 0;
            this.button_TaiKhoanNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaiKhoanNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TaiKhoanNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_TaiKhoanNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("button_TaiKhoanNhanVien.Image")));
            this.button_TaiKhoanNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoanNhanVien.Location = new System.Drawing.Point(0, 260);
            this.button_TaiKhoanNhanVien.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button_TaiKhoanNhanVien.Name = "button_TaiKhoanNhanVien";
            this.button_TaiKhoanNhanVien.Size = new System.Drawing.Size(579, 119);
            this.button_TaiKhoanNhanVien.TabIndex = 5;
            this.button_TaiKhoanNhanVien.Text = "          Tài khoản nhân viên";
            this.button_TaiKhoanNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoanNhanVien.UseVisualStyleBackColor = true;
            this.button_TaiKhoanNhanVien.Click += new System.EventHandler(this.button_TaiKhoanNhanVien_Click);
            // 
            // panel_LogoUeh
            // 
            this.panel_LogoUeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_LogoUeh.Controls.Add(this.guna2PictureBox1);
            this.panel_LogoUeh.Controls.Add(this.guna2CirclePictureBox1);
            this.panel_LogoUeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LogoUeh.Location = new System.Drawing.Point(0, 0);
            this.panel_LogoUeh.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_LogoUeh.Name = "panel_LogoUeh";
            this.panel_LogoUeh.Size = new System.Drawing.Size(579, 260);
            this.panel_LogoUeh.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(163, 91);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(400, 122);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(8, 60);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(171, 153);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // timer_SidebarTransition
            // 
            this.timer_SidebarTransition.Interval = 10;
            // 
            // panel_Sidebar
            // 
            this.panel_Sidebar.Controls.Add(this.button_ThongKe);
            this.panel_Sidebar.Controls.Add(this.panel_ChildQuanLiNhomThuoc);
            this.panel_Sidebar.Controls.Add(this.button_QuanLiNhanVien);
            this.panel_Sidebar.Controls.Add(this.panel_ChildQuanLiThuoc);
            this.panel_Sidebar.Controls.Add(this.button_QuanLiThuoc);
            this.panel_Sidebar.Controls.Add(this.button_XepLichLamViec);
            this.panel_Sidebar.Controls.Add(this.panel_ChildTaiKhoanNhanVien);
            this.panel_Sidebar.Controls.Add(this.button_TaiKhoanNhanVien);
            this.panel_Sidebar.Controls.Add(this.panel_LogoUeh);
            this.panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_Sidebar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Sidebar.Name = "panel_Sidebar";
            this.panel_Sidebar.Size = new System.Drawing.Size(579, 1877);
            this.panel_Sidebar.TabIndex = 4;
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(579, 260);
            this.panel_ChildForm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(3106, 1617);
            this.panel_ChildForm.TabIndex = 7;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3685, 1877);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Sidebar);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SearchIcon)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.panel_ChildTaiKhoanNhanVien.ResumeLayout(false);
            this.panel_ChildQuanLiThuoc.ResumeLayout(false);
            this.panel_ChildQuanLiNhomThuoc.ResumeLayout(false);
            this.panel_LogoUeh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel_Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.PictureBox pictureBox_SearchIcon;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_CurrentFunction;
        private System.Windows.Forms.Label label_CurrentPage;
        private System.Windows.Forms.Label label_DecorLine;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.Button button_QuanLiThuoc;
        private System.Windows.Forms.Button button_XepLichLamViec;
        private System.Windows.Forms.Panel panel_ChildTaiKhoanNhanVien;
        private System.Windows.Forms.Button button_ChinhSuaTaiKhoan;
        private System.Windows.Forms.Button button_Thongtin;
        private System.Windows.Forms.Button button_QuanLiNhanVien;
        private System.Windows.Forms.Panel panel_ChildQuanLiThuoc;
        private System.Windows.Forms.Button button_ChinhSuaThuoc;
        private System.Windows.Forms.Button button_ThongTinThuoc;
        private System.Windows.Forms.Timer timer_TaiKhoanNhanVienTransition;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.Panel panel_ChildQuanLiNhomThuoc;
        private System.Windows.Forms.Button button_ChinhSuaNhanVien;
        private System.Windows.Forms.Button button_ThongTinNhanVien;
        private System.Windows.Forms.Timer timer_QuanLiThuocTransition;
        private System.Windows.Forms.Timer timer_QuanLiNhomThuocTransition;
        private System.Windows.Forms.Button button_TaiKhoanNhanVien;
        private System.Windows.Forms.Panel panel_LogoUeh;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Timer timer_SidebarTransition;
        private System.Windows.Forms.Panel panel_Sidebar;
        private System.Windows.Forms.Panel panel_ChildForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}