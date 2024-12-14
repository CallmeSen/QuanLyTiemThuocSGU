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
            this.panel_Info = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.label_CurrentFunction = new System.Windows.Forms.Label();
            this.label_CurrentPage = new System.Windows.Forms.Label();
            this.label_DecorLine = new System.Windows.Forms.Label();
            this.label_Home = new System.Windows.Forms.Label();
            this.timer_QuanLiThuocTransition = new System.Windows.Forms.Timer(this.components);
            this.timer_QuanLiNhanVienTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_LogoUeh = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer_SidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel_Sidebar = new System.Windows.Forms.Panel();
            this.button_QuanLiKhachHang = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel_ChildQuanLiNhomThuoc = new System.Windows.Forms.Panel();
            this.button_ChinhSuaNhaCungCap = new System.Windows.Forms.Button();
            this.button_ThongTinNhanVien = new System.Windows.Forms.Button();
            this.button_QuanLiNhanVien = new System.Windows.Forms.Button();
            this.panel_ChildQuanLiThuoc = new System.Windows.Forms.Panel();
            this.button_ChinhSuaLoaiThuoc = new System.Windows.Forms.Button();
            this.button_ThongTinThuoc = new System.Windows.Forms.Button();
            this.button_QuanLiThuoc = new System.Windows.Forms.Button();
            this.button_TaiKhoanNhanVien = new System.Windows.Forms.Button();
            this.btnThuocHetHan = new System.Windows.Forms.Button();
            this.panel_ChildForm = new System.Windows.Forms.Panel();
            this.panel_Info.SuspendLayout();
            this.panel_LogoUeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel_Sidebar.SuspendLayout();
            this.panel_ChildQuanLiNhomThuoc.SuspendLayout();
            this.panel_ChildQuanLiThuoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Info
            // 
            this.panel_Info.Controls.Add(this.btnExit);
            this.panel_Info.Controls.Add(this.label_CurrentFunction);
            this.panel_Info.Controls.Add(this.label_CurrentPage);
            this.panel_Info.Controls.Add(this.label_DecorLine);
            this.panel_Info.Controls.Add(this.label_Home);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Info.Location = new System.Drawing.Point(289, 0);
            this.panel_Info.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(1635, 134);
            this.panel_Info.TabIndex = 6;
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
            this.btnExit.Location = new System.Drawing.Point(1711, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label_CurrentFunction
            // 
            this.label_CurrentFunction.AutoSize = true;
            this.label_CurrentFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CurrentFunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentFunction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(111)))), ((int)(((byte)(51)))));
            this.label_CurrentFunction.Location = new System.Drawing.Point(92, 36);
            this.label_CurrentFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CurrentFunction.Name = "label_CurrentFunction";
            this.label_CurrentFunction.Size = new System.Drawing.Size(0, 28);
            this.label_CurrentFunction.TabIndex = 3;
            this.label_CurrentFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_CurrentPage
            // 
            this.label_CurrentPage.AutoSize = true;
            this.label_CurrentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_CurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentPage.ForeColor = System.Drawing.Color.Black;
            this.label_CurrentPage.Location = new System.Drawing.Point(25, 12);
            this.label_CurrentPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CurrentPage.Name = "label_CurrentPage";
            this.label_CurrentPage.Size = new System.Drawing.Size(77, 32);
            this.label_CurrentPage.TabIndex = 0;
            this.label_CurrentPage.Text = "Pages";
            // 
            // label_DecorLine
            // 
            this.label_DecorLine.AutoSize = true;
            this.label_DecorLine.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DecorLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.label_DecorLine.Location = new System.Drawing.Point(24, 2);
            this.label_DecorLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DecorLine.Name = "label_DecorLine";
            this.label_DecorLine.Size = new System.Drawing.Size(78, 36);
            this.label_DecorLine.TabIndex = 2;
            this.label_DecorLine.Text = "_______";
            // 
            // label_Home
            // 
            this.label_Home.AutoSize = true;
            this.label_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Home.ForeColor = System.Drawing.Color.Black;
            this.label_Home.Location = new System.Drawing.Point(25, 47);
            this.label_Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Home.Name = "label_Home";
            this.label_Home.Size = new System.Drawing.Size(70, 28);
            this.label_Home.TabIndex = 1;
            this.label_Home.Text = "Home ";
            // 
            // timer_QuanLiThuocTransition
            // 
            this.timer_QuanLiThuocTransition.Interval = 10;
            this.timer_QuanLiThuocTransition.Tick += new System.EventHandler(this.timer_QuanLiThuocTransition_Tick);
            // 
            // timer_QuanLiNhanVienTransition
            // 
            this.timer_QuanLiNhanVienTransition.Interval = 10;
            this.timer_QuanLiNhanVienTransition.Tick += new System.EventHandler(this.timer_QuanLiNhanVienTransition_Tick);
            // 
            // panel_LogoUeh
            // 
            this.panel_LogoUeh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.panel_LogoUeh.Controls.Add(this.guna2PictureBox1);
            this.panel_LogoUeh.Controls.Add(this.guna2CirclePictureBox1);
            this.panel_LogoUeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_LogoUeh.Location = new System.Drawing.Point(0, 0);
            this.panel_LogoUeh.Margin = new System.Windows.Forms.Padding(4);
            this.panel_LogoUeh.Name = "panel_LogoUeh";
            this.panel_LogoUeh.Size = new System.Drawing.Size(289, 134);
            this.panel_LogoUeh.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(81, 47);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 63);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(4, 31);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(85, 79);
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
            this.panel_Sidebar.Controls.Add(this.button_QuanLiKhachHang);
            this.panel_Sidebar.Controls.Add(this.btnThongKe);
            this.panel_Sidebar.Controls.Add(this.panel_ChildQuanLiNhomThuoc);
            this.panel_Sidebar.Controls.Add(this.button_QuanLiNhanVien);
            this.panel_Sidebar.Controls.Add(this.panel_ChildQuanLiThuoc);
            this.panel_Sidebar.Controls.Add(this.button_QuanLiThuoc);
            this.panel_Sidebar.Controls.Add(this.button_TaiKhoanNhanVien);
            this.panel_Sidebar.Controls.Add(this.btnThuocHetHan);
            this.panel_Sidebar.Controls.Add(this.panel_LogoUeh);
            this.panel_Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_Sidebar.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Sidebar.Name = "panel_Sidebar";
            this.panel_Sidebar.Size = new System.Drawing.Size(289, 935);
            this.panel_Sidebar.TabIndex = 4;
            // 
            // button_QuanLiKhachHang
            // 
            this.button_QuanLiKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QuanLiKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_QuanLiKhachHang.FlatAppearance.BorderSize = 0;
            this.button_QuanLiKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuanLiKhachHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_QuanLiKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.button_QuanLiKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("button_QuanLiKhachHang.Image")));
            this.button_QuanLiKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiKhachHang.Location = new System.Drawing.Point(0, 690);
            this.button_QuanLiKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.button_QuanLiKhachHang.Name = "button_QuanLiKhachHang";
            this.button_QuanLiKhachHang.Size = new System.Drawing.Size(289, 62);
            this.button_QuanLiKhachHang.TabIndex = 25;
            this.button_QuanLiKhachHang.Text = "          Quản lí khách hàng";
            this.button_QuanLiKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiKhachHang.UseVisualStyleBackColor = true;
            this.button_QuanLiKhachHang.Click += new System.EventHandler(this.button_QuanLiKhachHang_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(0, 628);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(289, 62);
            this.btnThongKe.TabIndex = 24;
            this.btnThongKe.Text = "          Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel_ChildQuanLiNhomThuoc
            // 
            this.panel_ChildQuanLiNhomThuoc.Controls.Add(this.button_ChinhSuaNhaCungCap);
            this.panel_ChildQuanLiNhomThuoc.Controls.Add(this.button_ThongTinNhanVien);
            this.panel_ChildQuanLiNhomThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildQuanLiNhomThuoc.Location = new System.Drawing.Point(0, 505);
            this.panel_ChildQuanLiNhomThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildQuanLiNhomThuoc.Name = "panel_ChildQuanLiNhomThuoc";
            this.panel_ChildQuanLiNhomThuoc.Size = new System.Drawing.Size(289, 123);
            this.panel_ChildQuanLiNhomThuoc.TabIndex = 21;
            // 
            // button_ChinhSuaNhaCungCap
            // 
            this.button_ChinhSuaNhaCungCap.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ChinhSuaNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChinhSuaNhaCungCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ChinhSuaNhaCungCap.FlatAppearance.BorderSize = 0;
            this.button_ChinhSuaNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSuaNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ChinhSuaNhaCungCap.Location = new System.Drawing.Point(0, 62);
            this.button_ChinhSuaNhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChinhSuaNhaCungCap.Name = "button_ChinhSuaNhaCungCap";
            this.button_ChinhSuaNhaCungCap.Size = new System.Drawing.Size(289, 62);
            this.button_ChinhSuaNhaCungCap.TabIndex = 16;
            this.button_ChinhSuaNhaCungCap.Text = " > Quản lí nhà cung cấp";
            this.button_ChinhSuaNhaCungCap.UseVisualStyleBackColor = false;
            this.button_ChinhSuaNhaCungCap.Click += new System.EventHandler(this.button_ChinhSuaNhaCungCap_Click);
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
            this.button_ThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThongTinNhanVien.Name = "button_ThongTinNhanVien";
            this.button_ThongTinNhanVien.Size = new System.Drawing.Size(289, 62);
            this.button_ThongTinNhanVien.TabIndex = 15;
            this.button_ThongTinNhanVien.Text = "    > Quản lí nhân viên";
            this.button_ThongTinNhanVien.UseVisualStyleBackColor = false;
            this.button_ThongTinNhanVien.Click += new System.EventHandler(this.button_ThongTinNhanVien_Click);
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
            this.button_QuanLiNhanVien.Location = new System.Drawing.Point(0, 443);
            this.button_QuanLiNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.button_QuanLiNhanVien.Name = "button_QuanLiNhanVien";
            this.button_QuanLiNhanVien.Size = new System.Drawing.Size(289, 62);
            this.button_QuanLiNhanVien.TabIndex = 20;
            this.button_QuanLiNhanVien.Text = "            Quản lí thông tin ";
            this.button_QuanLiNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiNhanVien.UseVisualStyleBackColor = true;
            this.button_QuanLiNhanVien.Click += new System.EventHandler(this.button_QuanLiNhanVien_Click);
            // 
            // panel_ChildQuanLiThuoc
            // 
            this.panel_ChildQuanLiThuoc.Controls.Add(this.button_ChinhSuaLoaiThuoc);
            this.panel_ChildQuanLiThuoc.Controls.Add(this.button_ThongTinThuoc);
            this.panel_ChildQuanLiThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChildQuanLiThuoc.Location = new System.Drawing.Point(0, 320);
            this.panel_ChildQuanLiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildQuanLiThuoc.Name = "panel_ChildQuanLiThuoc";
            this.panel_ChildQuanLiThuoc.Size = new System.Drawing.Size(289, 123);
            this.panel_ChildQuanLiThuoc.TabIndex = 19;
            // 
            // button_ChinhSuaLoaiThuoc
            // 
            this.button_ChinhSuaLoaiThuoc.BackColor = System.Drawing.Color.Gainsboro;
            this.button_ChinhSuaLoaiThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ChinhSuaLoaiThuoc.FlatAppearance.BorderSize = 0;
            this.button_ChinhSuaLoaiThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChinhSuaLoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChinhSuaLoaiThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(94)))));
            this.button_ChinhSuaLoaiThuoc.Location = new System.Drawing.Point(0, 62);
            this.button_ChinhSuaLoaiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.button_ChinhSuaLoaiThuoc.Name = "button_ChinhSuaLoaiThuoc";
            this.button_ChinhSuaLoaiThuoc.Size = new System.Drawing.Size(289, 62);
            this.button_ChinhSuaLoaiThuoc.TabIndex = 1;
            this.button_ChinhSuaLoaiThuoc.Text = "           > Thông tin loại thuốc\r\n";
            this.button_ChinhSuaLoaiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ChinhSuaLoaiThuoc.UseVisualStyleBackColor = false;
            this.button_ChinhSuaLoaiThuoc.Click += new System.EventHandler(this.button_ThongTinLoaiThuoc_Click);
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
            this.button_ThongTinThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.button_ThongTinThuoc.Name = "button_ThongTinThuoc";
            this.button_ThongTinThuoc.Size = new System.Drawing.Size(289, 62);
            this.button_ThongTinThuoc.TabIndex = 0;
            this.button_ThongTinThuoc.Text = "           > Kho thuốc";
            this.button_ThongTinThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ThongTinThuoc.UseVisualStyleBackColor = false;
            this.button_ThongTinThuoc.Click += new System.EventHandler(this.button_ThongTinThuoc_Click);
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
            this.button_QuanLiThuoc.Location = new System.Drawing.Point(0, 258);
            this.button_QuanLiThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.button_QuanLiThuoc.Name = "button_QuanLiThuoc";
            this.button_QuanLiThuoc.Size = new System.Drawing.Size(289, 62);
            this.button_QuanLiThuoc.TabIndex = 18;
            this.button_QuanLiThuoc.Text = "           Quản lý thuốc";
            this.button_QuanLiThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_QuanLiThuoc.UseVisualStyleBackColor = true;
            this.button_QuanLiThuoc.Click += new System.EventHandler(this.button_QuanLiThuoc_Click);
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
            this.button_TaiKhoanNhanVien.Location = new System.Drawing.Point(0, 196);
            this.button_TaiKhoanNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.button_TaiKhoanNhanVien.Name = "button_TaiKhoanNhanVien";
            this.button_TaiKhoanNhanVien.Size = new System.Drawing.Size(289, 62);
            this.button_TaiKhoanNhanVien.TabIndex = 16;
            this.button_TaiKhoanNhanVien.Text = "          Tài khoản nhân viên";
            this.button_TaiKhoanNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_TaiKhoanNhanVien.UseVisualStyleBackColor = true;
            this.button_TaiKhoanNhanVien.Click += new System.EventHandler(this.button_TaiKhoanNhanVien_Click);
            // 
            // btnThuocHetHan
            // 
            this.btnThuocHetHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThuocHetHan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuocHetHan.FlatAppearance.BorderSize = 0;
            this.btnThuocHetHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuocHetHan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuocHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(185)))));
            this.btnThuocHetHan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuocHetHan.Location = new System.Drawing.Point(0, 134);
            this.btnThuocHetHan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThuocHetHan.Name = "btnThuocHetHan";
            this.btnThuocHetHan.Size = new System.Drawing.Size(289, 62);
            this.btnThuocHetHan.TabIndex = 15;
            this.btnThuocHetHan.Text = "          Tình trạng thuốc";
            this.btnThuocHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuocHetHan.UseVisualStyleBackColor = true;
            this.btnThuocHetHan.Click += new System.EventHandler(this.btnThuocHetHan_Click);
            // 
            // panel_ChildForm
            // 
            this.panel_ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ChildForm.Location = new System.Drawing.Point(289, 134);
            this.panel_ChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ChildForm.Name = "panel_ChildForm";
            this.panel_ChildForm.Size = new System.Drawing.Size(1635, 801);
            this.panel_ChildForm.TabIndex = 7;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 935);
            this.Controls.Add(this.panel_ChildForm);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.panel_Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.panel_LogoUeh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel_Sidebar.ResumeLayout(false);
            this.panel_ChildQuanLiNhomThuoc.ResumeLayout(false);
            this.panel_ChildQuanLiThuoc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Label label_CurrentFunction;
        private System.Windows.Forms.Label label_CurrentPage;
        private System.Windows.Forms.Label label_DecorLine;
        private System.Windows.Forms.Label label_Home;
        private System.Windows.Forms.Timer timer_QuanLiThuocTransition;
        private System.Windows.Forms.Timer timer_QuanLiNhanVienTransition;
        private System.Windows.Forms.Panel panel_LogoUeh;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Timer timer_SidebarTransition;
        private System.Windows.Forms.Panel panel_Sidebar;
        private System.Windows.Forms.Panel panel_ChildForm;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel_ChildQuanLiNhomThuoc;
        private System.Windows.Forms.Button button_ThongTinNhanVien;
        private System.Windows.Forms.Button button_QuanLiNhanVien;
        private System.Windows.Forms.Panel panel_ChildQuanLiThuoc;
        private System.Windows.Forms.Button button_ChinhSuaLoaiThuoc;
        private System.Windows.Forms.Button button_ThongTinThuoc;
        private System.Windows.Forms.Button button_QuanLiThuoc;
        private System.Windows.Forms.Button button_TaiKhoanNhanVien;
        private System.Windows.Forms.Button btnThuocHetHan;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button button_ChinhSuaNhaCungCap;
        private System.Windows.Forms.Button button_QuanLiKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}