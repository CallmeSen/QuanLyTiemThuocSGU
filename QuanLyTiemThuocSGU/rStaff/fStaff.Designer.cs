namespace QuanLyThuVienSGU_Winform
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_Sidebar = new System.Windows.Forms.Panel();
            this.button_ThuocHetHan = new System.Windows.Forms.Button();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.button_QuanLiKhachHang = new System.Windows.Forms.Button();
            this.panel_ChildQuanLiThuoc = new System.Windows.Forms.Panel();
            this.button_ChinhSuaThuoc = new System.Windows.Forms.Button();
            this.button_ThongTinThuoc = new System.Windows.Forms.Button();
            this.button_QuanLiThuoc = new System.Windows.Forms.Button();
            this.button_BanThuoc = new System.Windows.Forms.Button();
            this.button_TaiKhoanNhanVien = new System.Windows.Forms.Button();
            this.panel_LogoUeh = new System.Windows.Forms.Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.timer_SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.timer_QuanLiNhomThuocTransition = new System.Windows.Forms.Timer(this.components);
            this.timer_QuanLiThuocTransition = new System.Windows.Forms.Timer(this.components);
            this.timer_TaiKhoanNhanVienTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Info = new System.Windows.Forms.Panel();
            this.label_CurrentFunction = new System.Windows.Forms.Label();
            this.label_CurrentPage = new System.Windows.Forms.Label();
            this.label_DecorLine = new System.Windows.Forms.Label();
            this.label_Home = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel_Sidebar.SuspendLayout();
            this.panel_ChildQuanLiThuoc.SuspendLayout();
            this.panel_LogoUeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(61, 38);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 51);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel_Sidebar
            // 
            this.panel_Sidebar.Controls.Add(this.button_ThuocHetHan);
            this.panel_Sidebar.Controls.Add(this.button_ThongKe);
            this.panel_Sidebar.Controls.Add(this.button_QuanLiKhachHang);
            this.panel_Sidebar.Controls.Add(this.panel_ChildQuanLiThuoc);
            this.panel_Sidebar.Controls.Add(this.button_QuanLiThuoc);
            this.panel_Sidebar.Controls.Add(this.button_BanThuoc);
            this.panel_Sidebar.Controls.Add(this.button_TaiKhoanNhanVien);
            this.panel_Sidebar.Controls.Add(this.panel_LogoUeh);
            this.panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_Sidebar.Name = "panel_Sidebar";
            this.panel_Sidebar.Size = new System.Drawing.Size(217, 546);
            this.panel_Sidebar.TabIndex = 8;
            // 
            // button_ThuocHetHan
            // 
            this.button_ThuocHetHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThuocHetHan.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ThuocHetHan.FlatAppearance.BorderSize = 0;
            this.button_ThuocHetHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThuocHetHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThuocHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_ThuocHetHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThuocHetHan.Location = new System.Drawing.Point(0, 459);
            this.button_ThuocHetHan.Name = "button_ThuocHetHan";
            this.button_ThuocHetHan.Size = new System.Drawing.Size(217, 50);
            this.button_ThuocHetHan.TabIndex = 14;
            this.button_ThuocHetHan.Text = "          Thuốc Hết Hạn";
            this.button_ThuocHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThuocHetHan.UseVisualStyleBackColor = true;
            this.button_ThuocHetHan.Click += new System.EventHandler(this.btnThuocHetHan_Click);
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
            this.button_ThongKe.Location = new System.Drawing.Point(0, 409);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(217, 50);
            this.button_ThongKe.TabIndex = 12;
            this.button_ThongKe.Text = "          Thống kê";
            this.button_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongKe.UseVisualStyleBackColor = true;
            // 
            // button_QuanLiKhachHang
            // 
            this.button_QuanLiKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QuanLiKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_QuanLiKhachHang.FlatAppearance.BorderSize = 0;
            this.button_QuanLiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuanLiKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLiKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_QuanLiKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiKhachHang.Location = new System.Drawing.Point(0, 359);
            this.button_QuanLiKhachHang.Name = "button_QuanLiKhachHang";
            this.button_QuanLiKhachHang.Size = new System.Drawing.Size(217, 50);
            this.button_QuanLiKhachHang.TabIndex = 10;
            this.button_QuanLiKhachHang.Text = "          Quản lí khách hàng";
            this.button_QuanLiKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiKhachHang.UseVisualStyleBackColor = true;
            this.button_QuanLiKhachHang.Click += new System.EventHandler(this.button_QuanLiKhachHang_Click);
            // 
            // panel_ChildQuanLiThuoc
            // 
            this.panel_ChildQuanLiThuoc.Controls.Add(this.button_ChinhSuaThuoc);
            this.panel_ChildQuanLiThuoc.Controls.Add(this.button_ThongTinThuoc);
            this.panel_ChildQuanLiThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildQuanLiThuoc.Location = new System.Drawing.Point(0, 259);
            this.panel_ChildQuanLiThuoc.Name = "panel_ChildQuanLiThuoc";
            this.panel_ChildQuanLiThuoc.Size = new System.Drawing.Size(217, 100);
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
            this.button_ChinhSuaThuoc.Location = new System.Drawing.Point(0, 50);
            this.button_ChinhSuaThuoc.Name = "button_ChinhSuaThuoc";
            this.button_ChinhSuaThuoc.Size = new System.Drawing.Size(217, 50);
            this.button_ChinhSuaThuoc.TabIndex = 1;
            this.button_ChinhSuaThuoc.Text = "          Quản lí nhóm thuốc";
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
            this.button_ThongTinThuoc.Name = "button_ThongTinThuoc";
            this.button_ThongTinThuoc.Size = new System.Drawing.Size(217, 50);
            this.button_ThongTinThuoc.TabIndex = 0;
            this.button_ThongTinThuoc.Text = "           > Thông tin thuốc ";
            this.button_ThongTinThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongTinThuoc.UseVisualStyleBackColor = false;
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
            this.button_QuanLiThuoc.Location = new System.Drawing.Point(0, 209);
            this.button_QuanLiThuoc.Name = "button_QuanLiThuoc";
            this.button_QuanLiThuoc.Size = new System.Drawing.Size(217, 50);
            this.button_QuanLiThuoc.TabIndex = 8;
            this.button_QuanLiThuoc.Text = "           Quản lý thuốc";
            this.button_QuanLiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiThuoc.UseVisualStyleBackColor = true;
            this.button_QuanLiThuoc.Click += new System.EventHandler(this.button_QuanLiThuoc_Click);
            // 
            // button_BanThuoc
            // 
            this.button_BanThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BanThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_BanThuoc.FlatAppearance.BorderSize = 0;
            this.button_BanThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BanThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BanThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_BanThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BanThuoc.Location = new System.Drawing.Point(0, 159);
            this.button_BanThuoc.Name = "button_BanThuoc";
            this.button_BanThuoc.Size = new System.Drawing.Size(217, 50);
            this.button_BanThuoc.TabIndex = 7;
            this.button_BanThuoc.Text = "          Bán Thuốc\r\n";
            this.button_BanThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BanThuoc.UseVisualStyleBackColor = true;
            this.button_BanThuoc.Click += new System.EventHandler(this.button_BanThuoc_Click);
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
            this.button_TaiKhoanNhanVien.Location = new System.Drawing.Point(0, 109);
            this.button_TaiKhoanNhanVien.Name = "button_TaiKhoanNhanVien";
            this.button_TaiKhoanNhanVien.Size = new System.Drawing.Size(217, 50);
            this.button_TaiKhoanNhanVien.TabIndex = 5;
            this.button_TaiKhoanNhanVien.Text = "          Tài khoản nhân viên";
            this.button_TaiKhoanNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoanNhanVien.UseVisualStyleBackColor = true;
            this.button_TaiKhoanNhanVien.Click += new System.EventHandler(this.button_Thongtin_Click);
            // 
            // panel_LogoUeh
            // 
            this.panel_LogoUeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_LogoUeh.Controls.Add(this.guna2PictureBox1);
            this.panel_LogoUeh.Controls.Add(this.guna2CirclePictureBox1);
            this.panel_LogoUeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LogoUeh.Location = new System.Drawing.Point(0, 0);
            this.panel_LogoUeh.Name = "panel_LogoUeh";
            this.panel_LogoUeh.Size = new System.Drawing.Size(217, 109);
            this.panel_LogoUeh.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 25);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(217, 109);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(1323, 437);
            this.panel_ChildForm.TabIndex = 11;
            // 
            // timer_SidebarTransition
            // 
            this.timer_SidebarTransition.Interval = 10;
            // 
            // timer_QuanLiNhomThuocTransition
            // 
            this.timer_QuanLiNhomThuocTransition.Interval = 10;
            // 
            // timer_QuanLiThuocTransition
            // 
            this.timer_QuanLiThuocTransition.Interval = 10;
            this.timer_QuanLiThuocTransition.Tick += new System.EventHandler(this.timer_QuanLiThuocTransition_Tick);
            // 
            // timer_TaiKhoanNhanVienTransition
            // 
            this.timer_TaiKhoanNhanVienTransition.Interval = 10;
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.btnExit);
            this.panel_Info.Controls.Add(this.label_CurrentFunction);
            this.panel_Info.Controls.Add(this.label_CurrentPage);
            this.panel_Info.Controls.Add(this.label_DecorLine);
            this.panel_Info.Controls.Add(this.label_Home);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(217, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(1323, 109);
            this.panel_Info.TabIndex = 13;
            // 
            // label_CurrentFunction
            // 
            this.label_CurrentFunction.AutoSize = true;
            this.label_CurrentFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CurrentFunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.label_CurrentFunction.Location = new System.Drawing.Point(69, 29);
            this.label_CurrentFunction.Name = "label_CurrentFunction";
            this.label_CurrentFunction.Size = new System.Drawing.Size(0, 21);
            this.label_CurrentFunction.TabIndex = 3;
            this.label_CurrentFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_CurrentPage
            // 
            this.label_CurrentPage.AutoSize = true;
            this.label_CurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentPage.ForeColor = System.Drawing.Color.Black;
            this.label_CurrentPage.Location = new System.Drawing.Point(19, 1);
            this.label_CurrentPage.Name = "label_CurrentPage";
            this.label_CurrentPage.Size = new System.Drawing.Size(61, 25);
            this.label_CurrentPage.TabIndex = 0;
            this.label_CurrentPage.Text = "Pages";
            // 
            // label_DecorLine
            // 
            this.label_DecorLine.AutoSize = true;
            this.label_DecorLine.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DecorLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.label_DecorLine.Location = new System.Drawing.Point(18, 2);
            this.label_DecorLine.Name = "label_DecorLine";
            this.label_DecorLine.Size = new System.Drawing.Size(62, 29);
            this.label_DecorLine.TabIndex = 2;
            this.label_DecorLine.Text = "_______";
            // 
            // label_Home
            // 
            this.label_Home.AutoSize = true;
            this.label_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home.ForeColor = System.Drawing.Color.Black;
            this.label_Home.Location = new System.Drawing.Point(19, 29);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(56, 21);
            this.label_Home.TabIndex = 1;
            this.label_Home.Text = "Home ";
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1283, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 32);
            this.btnExit.TabIndex = 14;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 546);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Sidebar);
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel_Sidebar.ResumeLayout(false);
            this.panel_ChildQuanLiThuoc.ResumeLayout(false);
            this.panel_LogoUeh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel_Sidebar;
        private System.Windows.Forms.Button button_QuanLiKhachHang;
        private System.Windows.Forms.Panel panel_ChildQuanLiThuoc;
        private System.Windows.Forms.Button button_ChinhSuaThuoc;
        private System.Windows.Forms.Button button_ThongTinThuoc;
        private System.Windows.Forms.Button button_QuanLiThuoc;
        private System.Windows.Forms.Button button_TaiKhoanNhanVien;
        private System.Windows.Forms.Panel panel_LogoUeh;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel_ChildForm;
        private System.Windows.Forms.Timer timer_SidebarTransition;
        private System.Windows.Forms.Timer timer_QuanLiNhomThuocTransition;
        private System.Windows.Forms.Timer timer_QuanLiThuocTransition;
        private System.Windows.Forms.Timer timer_TaiKhoanNhanVienTransition;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_CurrentFunction;
        private System.Windows.Forms.Label label_CurrentPage;
        private System.Windows.Forms.Label label_DecorLine;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.Button button_ThongKe;
        private System.Windows.Forms.Button button_ThuocHetHan;
        private System.Windows.Forms.Button button_BanThuoc;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}